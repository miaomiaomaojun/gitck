Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class system_class
    Public erro As String = ""
#Region "注册"

    ''' <summary>
    ''' 用户注册
    ''' </summary>
    ''' <param name="yhm">传入用户名</param>
    ''' <param name="mm">密码</param>
    ''' <returns>操作成功返回空</returns>
    ''' <remarks></remarks>
    Public Function reg_add(ByVal yhm As String, ByVal mm As String) As String
        Dim reg As New Regex("^1[3|4|5|7|8][0-9]\d{4,8}$")
        If reg.IsMatch(yhm) = False Then
            Return "用户名格式不正确，用户名必须是手机。"
        End If
        If mm.Length > 15 Or mm.Length < 5 Then
            Return "密码字符输入违规！"
        End If

        Dim jcmm As String = ym.aqjc(mm)
        If jcmm <> "" Then
            Return "密码中不能有特殊字符" & jcmm
        End If
        Dim db As New mysjk("Systemk")
        Dim md5mm As String = md5jm.Encrypt(yhm & mm, 32) 'md5加盐
        Dim str As String = "insert into reg_table (yhm,mm) values ('" & yhm & "','" & md5mm & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "用户名注册出错，请联系技术部"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 检测用户名
    ''' </summary>
    ''' <param name="yhmc">传入要检测的用户名</param>
    ''' <returns>错误返回e,存在返回y，不存在返回n</returns>
    ''' <remarks></remarks>
    Public Function test_username(ByVal yhmc As String) As String
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from reg_table where yhm='" & yhmc & "'"
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return "e"
        End If
        If tb.Rows.Count > 0 Then
            Return "y"
        Else
            Return "n"
        End If
    End Function
    '
    ''' <summary>
    ''' 读取用户-测试用的，
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function read_username() As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select * from reg_table order by bh desc"
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function

    '
    ''' <summary>
    ''' 无旧密码重置-管理员使用
    ''' </summary>
    ''' <param name="yhm">传入用户名</param>
    ''' <param name="mm">传入修改密码</param>
    ''' <returns>操作成功返回空</returns>
    ''' <remarks></remarks>
    Public Function Reset_passwored(ByVal yhm As String, ByVal mm As String) As String
        If yhm = "" Then
            Return "用户名不能为空"
        End If
        If ym.aqjc(yhm) <> "" Then
            Return "用户名不支持特殊字符" & ym.aqjc(yhm)
        End If
        Dim reg As New Regex("^[1]+[3,5]+\d{9}")
        If reg.IsMatch(yhm) = False Then

            Return "用户名格式不正确，用户名必须是手机。"
        End If
        If mm = "" Then
            Return "密码不能为空"
        End If
        If ym.aqjc(mm) <> "" Then
            Return "密码不支持特殊字符 " & ym.aqjc(mm)
        End If
        If mm.Length > 15 Or mm.Length < 7 Then
            Return "密码格式输入不正确"
        End If
        Dim password_md5 As String = md5jm.Encrypt(yhm & mm, 32) '原密码加盐
        Dim db As New mysjk("Systemk")
        Dim zx As Integer = db.zx1("update reg_table set mm='" & password_md5 & "' where yhm='" & yhm & "'")
        If db.exerr <> "" Then
            Return "修改密码出错，请重试"
        End If
        Return ""
        'Dim str As String = "insert into yhdlb (yhm,ip,sj,ymm,xmm) values('" & yhm & "','" & HttpContext.Current.Request.UserHostAddress & "','" & Now & "','','" & password_md5 & "')"
        'zx = db.zx1(str)
        'If zx < 0 Then
        '    erro = "新增用户出错，请重新打开空间查看"
        '    Exit Sub
        'End If
    End Function
    '
    ''' <summary>
    ''' 修改密码-普通用户
    ''' </summary>
    ''' <param name="yhm">传入用户名</param>
    ''' <param name="o_mm">传入原密码</param>
    ''' <param name="n_mm">传入新密码</param>
    ''' <returns>操作成功返回空</returns>
    ''' <remarks></remarks>
    Public Function edit_yh(ByVal yhm As String, ByVal o_mm As String, ByVal n_mm As String) As String
        If yhm = "" Then
            Return "用户名不能为空"
        End If
        Dim reg As New Regex("^[1]+[3,5]+\d{9}")
        If reg.IsMatch(yhm) = False Then
            Return "用户名格式不正确，用户名必须是手机。"
        End If
        If ym.aqjc(yhm) <> "" Then
            Return "用户名不支持特殊字符" & ym.aqjc(yhm)
        End If
        If o_mm = "" Then
            Return "原密码不能为空"
        End If
        If o_mm.Length > 15 Or o_mm.Length < 5 Then
            Return "原密码格式不正确，是5-15位字符"
        End If
        If ym.aqjc(o_mm) <> "" Then
            Return "原密码不支持特殊字符 " & ym.aqjc(o_mm)
        End If
        If n_mm = "" Then

            Return "新密码不能为空"
        End If
        If ym.aqjc(n_mm) <> "" Then
            Return "新密码不支持特殊字符 " & ym.aqjc(o_mm)
        End If
        If n_mm.Length > 15 Or n_mm.Length < 5 Then
            Return "新密码格式不正确，是5-15位字符"
        End If
        Dim tb As DataTable = Nothing
        Dim db As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from reg_table where yhm='" & yhm & "'"
        tb = db.dqb(str)
        If db.exerr <> "" Then
            'erro = db.exerr
            Return "修改密码过程中，检测用户名出错，请联系客服"
        End If
        Dim o_md5 As String = md5jm.Encrypt(yhm & o_mm, 32) '原密码加盐
        If tb.Rows(0)("mm").ToString <> o_md5 Then
            Return "原密码不正确！"
        End If
        Dim n_md5 As String = md5jm.Encrypt(yhm & n_mm, 32)
        Dim zx As Integer = db.zx1("update reg_table set mm='" & n_md5 & "' where yhm='" & yhm & "'")
        If db.exerr <> "" Then
            Return "修改密码出错，请重试"
        End If
        Return ""
        'str = "insert into xgmmb (yhm,ip,sj,ymm,xmm) values('" & yhm & "','" & HttpContext.Current.Request.UserHostAddress & "','" & Now & "','" & o_md5 & "','" & n_md5 & "')"
        'zx = db.zx1(str)
        'If zx < 0 Then
        '    erro = "新增用户出错，请重新打开空间查看"
        '    Exit Sub
        'End If
    End Function

#End Region
#Region "用户身份认证"
    '
    ''' <summary>
    ''' 插入身份认证
    ''' </summary>
    ''' <param name="user_bh">用户库编号</param>
    ''' <param name="img1">身份证正面照</param>
    ''' <param name="img2">身份证背面照</param>
    ''' <param name="xm">姓名</param>
    ''' <param name="idh">身份证号码</param>
    ''' <param name="xb">性别</param>
    ''' <returns>操作成功返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_id(ByVal user_bh As Integer, ByVal img1 As String, ByVal img2 As String, ByVal xm As String, ByVal idh As String, ByVal xb As Integer) As String
        If IsNumeric(user_bh) = False Then
            Return "用户编号必须是数字"
        End If
        If img1 = "" Or img2 = "" Then
            Return "尚未选择要上传身份证认证图片"
        End If
        If img1.Length > 200 Or img2.Length > 200 Then
            Return "图片路径字符长度超过限定！"
        End If
        If xm = "" Then
            Return "认证人姓名不能为空"
        End If
        If xm.Length > 5 Then
            Return "认证人姓名字符长度不能超过5位"
        End If
        Dim jcxm As String = ym.aqjc(xm)
        If jcxm <> "" Then
            Return "认证人姓名中不能有特殊字符" & jcxm
        End If

        If idh = "" Then
            Return "认证人身份证号不能为空"
        End If
        If idh.Length > 5 Then
            Return "认证人身份证号字符长度不能超过18位"
        End If

        Dim jcidh As String = ym.aqjc(idh)
        If jcidh <> "" Then
            Return "认证人身份证号中不能有特殊字符" & jcidh
        End If
        If IsNumeric(xb) = False Then

            Return "性别输入必须是数字"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into ID_authentication (user_bh,ID_img1,ID_img2,name,ID_number,sj,zt,sex) values(" & user_bh & ",'" & img1 & "','" & img2 & "','" & xm & "','" & idh & "','" & Now.ToString & "',2," & xb & ")"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "身份证认证插入出错"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取身份认证信息(用户编号-普通用户使用)
    ''' </summary>
    ''' <param name="user_bh">用户编号</param>
    ''' <returns>成功返回表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function dq_idrz(ByVal user_bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from ID_authentication where user_bh=" & user_bh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 身份证认证库编号读取
    ''' </summary>
    ''' <param name="bh">身份证认证库编号</param>
    ''' <returns>成功返回表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function dq_idrz_bh(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from ID_authentication where bh=" & bh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '修改认证状态
    ''' <summary>
    ''' 修改认证状态
    ''' </summary>
    ''' <param name="bh">身份证认证库编号</param>
    ''' <param name="zt">身份证认证库状态</param>
    ''' <returns>成功返回空值</returns>
    ''' <remarks></remarks>
    Public Function edti_idrz(ByVal bh As Integer, ByVal zt As Integer) As String
        Dim db As New mysjk("Systemk")
        Dim zx As Integer = db.zx1("update ID_authentication set zt=" & zt & " where bh=" & bh)
        If db.exerr <> "" Then
            Return "修改用户认证资料失败"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 身份证信息重新录入
    ''' </summary>
    ''' <param name="userbh">用户库编号</param>
    ''' <param name="img1">身份证正面照</param>
    ''' <param name="img2">身份证背面照</param>
    ''' <param name="xm">姓名</param>
    ''' <param name="idh">身份证号码</param>
    ''' <param name="xb">性别</param>
    ''' <returns>操作成功返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_idrz_agreen(ByVal userbh As Integer, ByVal img1 As String, ByVal img2 As String, ByVal xm As String, ByVal idh As String, ByVal xb As Integer) As String
        Dim db As New mysjk("Systemk")
        Dim str As String = "update idrz_b set ID_img1='" & img1 & "',ID_img2='" & img2 & "',name='" & xm & "',ID_number='" & idh & "',zt=2,sex=" & xb & " where user_bh=" & userbh

        Dim zx As Integer = db.zx1(str)
        If db.exerr <> "" Then
            Return "身份证认证信息录入失败"
        End If
        Return ""
    End Function
#End Region
#Region "汽车认证"
    '
    ''' <summary>
    ''' 增加汽车认证请求
    ''' </summary>
    ''' <param name="user_bh">用户编号</param>
    ''' <param name="carimg">车辆照片</param>
    ''' <param name="dringicimg">行驶证照片</param>
    ''' <param name="carnumber">车牌照片</param>
    ''' <returns>操作完成后返回空</returns>
    ''' <remarks></remarks>
    Public Function add_car_authentication(ByVal user_bh As Integer, ByVal carimg As String, ByVal dringicimg As String, ByVal carnumber As String) As String
        If IsNumeric(user_bh) = False Then
            Return "用户编号必须是数字"
        End If
        If carimg = "" Then
            Return "请上传汽车照片"
        End If
        If carimg.Length > 200 Then
            Return "汽车照片存储路径长度违规"
        End If
        If dringicimg = "" Then
            Return "请上传行驶证照片"
        End If
        If dringicimg.Length > 200 Then
            Return "请上传行驶证照片"
        End If
        If carnumber = "" Then
            Return "请上传车牌号"
        End If
        If carnumber.Length > 7 Then
            Return "车牌号字符长度不能超过7位字符"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into Car_authentication (user_bh,carimg,driving_IC_img,car_number,zt) values(" & user_bh & ",'" & carimg & "','" & dringicimg & "','" & carnumber & "',2)"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "汽车认证插入出错"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取汽车认证-用户编号
    ''' </summary>
    ''' <param name="userbh">用户库编号</param>
    ''' <returns>操作完成后返回表</returns>
    ''' <remarks></remarks>
    Public Function dq_car_user(ByVal userbh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from Car_authentication where user_bh=" & userbh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 读取汽车认证-编号
    ''' </summary>
    ''' <param name="bh">汽车认证库编号</param>
    ''' <returns>操作完成后返回表，失败返回Nothing</returns>
    ''' <remarks></remarks>
    Public Function dq_car_bh(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from Car_authentication where bh=" & bh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 修改认证信息
    ''' </summary>
    ''' <param name="bh">汽车认证库编号</param>
    ''' <param name="carimg">汽车照片</param>
    ''' <param name="driving_ic_img">行驶证照片</param>
    ''' <param name="carnumber">汽车牌号</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function edit_car_authentication_news(ByVal bh As Integer, ByVal carimg As String, ByVal driving_ic_img As String, ByVal carnumber As String) As String
        If carimg = "" Then
            Return "请上传汽车照片"
        End If
        If carimg.Length > 200 Then
            Return "汽车照片存储路径长度违规"
        End If
        If driving_ic_img = "" Then
            Return "请上传行驶证照片"
        End If
        If driving_ic_img.Length > 200 Then
            Return "请上传行驶证照片"
        End If
        If carnumber = "" Then
            Return "请上传车牌号"
        End If
        If carnumber.Length > 7 Then
            Return "车牌号字符长度不能超过7位字符"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update Car_authentication set carimg='" & carimg & "',driving_IC_img='" & driving_ic_img & "',car_number='" & carnumber & "',zt=2 where bh=" & bh
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "汽车认证修改出错，请联系网站管理员"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 审核处理-网站管理
    ''' </summary>
    ''' <param name="zt">状态</param>
    ''' <param name="operationer">操作人</param>
    ''' <param name="bz">备注信息</param>
    ''' <param name="bh">汽车认证编号</param>
    ''' <returns>操作成功返回空值</returns>
    ''' <remarks></remarks>
    Public Function examine_car_authentication(ByVal zt As Integer, ByVal operationer As String, ByVal bz As String, ByVal bh As Integer) As String
        If bz <> "" Then
            If bz.Length > 100 Then
                Return "备注中所填内容益处，请简写。"
            End If
            Dim jcbz As String = ym.aqjc(bz)
            If jcbz <> "" Then
                Return "备注内容中不能有特殊字符" & jcbz
            End If
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update Car_authentication set zt=" & zt & ",operation_man='" & operationer & "',bz='" & bz & "' where bh=" & bh
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "操作审核失败，请联系技术部"
        End If
        Return ""
    End Function

#End Region

#Region "申请开设店铺需求"
    '
    ''' <summary>
    ''' 插入申请表
    ''' </summary>
    ''' <param name="yhbh">用户库编号</param>
    ''' <param name="xm">姓名</param>
    ''' <param name="shopname">店铺名称</param>
    ''' <param name="dh">电话</param>
    ''' <param name="dz">地址</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_shop_need(ByVal yhbh As Integer, ByVal xm As String, ByVal shopname As String, ByVal dh As String, ByVal dz As String) As String
        If IsNumeric(yhbh) = False Then
            Return "用户编号传入不正确，必须是数字"
        End If
        If xm = "" Then
            Return "姓名不能为空"
        End If
        If xm.Length > 5 Then
            Return "姓名字符长度不能超过5位"
        End If
        If shopname = "" Then
            Return "请填写店铺名称"
        End If
        If shopname.Length > 50 Then
            Return "店铺名称字数不能超过50个"
        End If
        Dim jcshopname As String = ym.aqjc(shopname)
        If jcshopname <> "" Then
            Return "店铺名称中不能有特殊字符" & jcshopname
        End If
        Dim jcxm As String = ym.aqjc(xm)
        If jcxm <> "" Then
            Return "姓名中不能有特殊字符" & jcxm
        End If

        Dim reg As New Regex("^[1]+[3,5]+\d{9}")
        If reg.IsMatch(dh) = False Then
            Return "联系手机格式输入有误"
        End If

        If dz = "" Then
            Return "地址不能为空"
        End If
        If dz.Length > 200 Then
            Return "地址字符长度不能超过5位"
        End If
        Dim jcdz As String = ym.aqjc(dz)
        If jcxm <> "" Then
            Return "地址中不能有特殊字符" & jcxm
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into shop_need (user_bh,name,phone,dz,sj,zt,shopname) values(" & yhbh & ",'" & xm & "','" & dh & "','" & dz & "','" & Now.ToString & "',0,'" & shopname & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "插入开设商铺需求出错。"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改申请表
    ''' </summary>
    ''' <param name="bh">开店请求编号</param>
    ''' <param name="xm">姓名</param>
    ''' <param name="shopname">店铺名称</param>
    ''' <param name="dh">电话</param>
    ''' <param name="dz">地址</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_shop_need(ByVal bh As Integer, ByVal xm As String, ByVal shopname As String, ByVal dh As String, ByVal dz As String) As String
        If IsNumeric(dh) = False Then
            Return "用户传入不正确，必须是数字"
        End If
        If xm = "" Then
            Return "姓名不能为空"
        End If
        If xm.Length > 5 Then
            Return "姓名字符长度不能超过5位"
        End If
        Dim jcxm As String = ym.aqjc(xm)
        If jcxm <> "" Then

            Return "姓名中不能有特殊字符" & jcxm
        End If
        If shopname = "" Then
            Return "请填写店铺名称"
        End If
        If shopname.Length > 50 Then
            Return "店铺名称字数不能超过50个"
        End If
        Dim jcshopname As String = ym.aqjc(shopname)
        If jcshopname <> "" Then
            Return "店铺名称中不能有特殊字符" & jcshopname
        End If
        Dim reg As New Regex("^[1]+[3,5]+\d{9}")
        If reg.IsMatch(dh) = False Then
            Return "联系手机格式输入有误"
        End If

        If dz = "" Then
            Return "地址不能为空"
        End If
        If dz.Length > 200 Then
            Return "地址字符长度不能超过5位"
        End If
        Dim jcdz As String = ym.aqjc(dz)
        If jcxm <> "" Then
            Return "地址中不能有特殊字符" & jcxm
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update shop_need set name='" & xm & "',phone='" & dh & "',zt=0,dz='" & dz & "',shopname='" & shopname & "' where bh=" & bh

        Dim zx As Integer = db.zx1(str)
        If db.exerr <> "" Then
            Return "修改商铺信息录入失败"
        End If
        Return ""
    End Function
    'AJAX 命令调用
    ''' <summary>
    ''' 处理开店请求
    ''' </summary>
    ''' <param name="bh">请求库编号</param>
    ''' <param name="zt">请求库编号对应的状态</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function ajax_edit_shopneed(ByVal bh As Integer, ByVal zt As Integer) As String
        Dim err_question As String = ""
        Select Case zt
            Case 1
                err_question = "已处理"
            Case 2
                err_question = "其他"
            Case Else
                err_question = "zt传值不在要求范围内"
        End Select
        Dim db As New mysjk("Systemk")
        Dim str As String = "update shop_need set zt=" & zt & " where bh=" & bh
        Dim zx As Integer = db.zx1(str)
        If db.exerr <> "" Then
            Return "商铺需求" & err_question & "状态失败"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取单条需求
    ''' </summary>
    ''' <param name="bh">读取请求库编号</param>
    ''' <returns>操作完成后返回表，操作失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_one_shopneed(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from shop_need where bh=" & bh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
#End Region
#Region "店铺控制总台"
    '插入信息
    ''' <summary>
    ''' 插入店铺总控
    ''' </summary>
    ''' <param name="yhbh">用户编号</param>
    ''' <param name="starsj">开始时间</param>
    ''' <param name="endsj">结束时间</param>
    ''' <param name="xm">姓名</param>
    ''' <param name="dh">电话</param>
    ''' <param name="IDimg">身份证正面照片</param>
    ''' <param name="b_l_img">营业执照照片</param>
    ''' <param name="h_l_img">卫生许可证照片</param>
    ''' <param name="contractid">合同编号</param>
    ''' <param name="contractimg">合同照片</param>
    ''' <param name="signatory">签约人</param>
    ''' <param name="addpeople">创建人</param>
    ''' <returns>操作成功后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_shop_person_list(ByVal yhbh As Integer, ByVal starsj As String, ByVal endsj As String, ByVal xm As String, ByVal dh As String, ByVal IDimg As String, ByVal b_l_img As String, ByVal h_l_img As String, ByVal contractid As String, ByVal contractimg As String, ByVal signatory As String, ByVal addpeople As String) As String
        If IsNumeric(yhbh) = False Then
            Return "用户编号传入不正确，必须是数字"
        End If
        If IsDate(starsj) = False Then
            Return "开始时间传入有误"
        End If
        If IsDate(endsj) = False Then
            Return "结束时间传入有误"
        End If
        If xm = "" Then
            Return "店主姓名不能为空"
        End If
        If xm.Length > 10 Then
            Return "店主姓名字符长度不能超过10个"
        End If
        Dim jcxm As String = ym.aqjc(xm)
        If jcxm <> "" Then
            Return "店主姓名中不能有特殊字符" & jcxm
        End If
        If dh = "" Then
            Return "电话不能为空"
        End If
        If dh.Length > 13 Then
            Return "电话字符长度不能超过13个字符"
        End If
        Dim jcdh As String = ym.aqjc(dh)
        If jcdh <> "" Then
            Return "联系电话中不能有特殊字符" & jcdh
        End If
        If IDimg = "" Then
            Return "请选择店主身份证照片"
        End If
        If IDimg.Length > 200 Then
            Return "图片地址存储路径长度违规"
        End If
        If b_l_img = "" Then
            Return "请上传营业执照图片"
        End If
        If b_l_img.Length > 200 Then
            Return "营业执照地址存储图片路径违规"
        End If
        If contractid = "" Then
            Return "请填写合同编号"
        End If
        If contractid.Length > 50 Then
            Return "合同编号字符长度不能超过50位"
        End If
        Dim jccontractid As String = ym.aqjc(contractid)
        If jccontractid <> "" Then
            Return "合同编号中不能有特殊字符" & jccontractid
        End If
        If contractimg = "" Then
            Return "请上传合同照片"
        End If
        If contractimg.Length > 200 Then
            Return "合同照片存储路径字符长度违规"
        End If
        If signatory = "" Then
            Return "请填写签约人姓名"
        End If
        If signatory.Length > 10 Then
            Return "签约人姓名字符长度不能超过10个字符"
        End If
        Dim jcsignatory As String = ym.aqjc(signatory)
        If jcsignatory <> "" Then
            Return "签约人姓名总不能含有特殊字符" & jcsignatory
        End If
        If addpeople = "" Then
            Return "创建人姓名不能为空"
        End If
        If addpeople.Length > 10 Then
            Return "创建人姓名字符长度不能超过10位"
        End If
        'ByVal yhbh As Integer, ByVal starsj As String, ByVal endsj As String, ByVal xm As String, ByVal dh As String, ByVal IDimg As String, ByVal b_l_img As String, ByVal contractid As String, ByVal contractimg As String, ByVal signatory As String, ByVal addpeople As String
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into shop_person_list (user_bh,star_sj,end_sj,xm,dh,ID_img,business_license_img,hygiene_license_img,contract_id,contract_img,signatory,add_people,sj,zt,Openator) "
        str &= "values(" & yhbh & ",'" & starsj & "','" & endsj & "','" & xm & "','" & dh & "','" & IDimg & "','" & b_l_img & "','" & h_l_img & "','" & contractid & "','" & contractimg & "','" & signatory & "','" & addpeople & "','" & Now.ToString & "',1,'')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "插入开设商铺控制总台库出错。"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 总台信息修改
    ''' </summary>
    ''' <param name="yhbh">用户编号</param>
    ''' <param name="starsj">开始时间</param>
    ''' <param name="endsj">结束时间</param>
    ''' <param name="xm">姓名</param>
    ''' <param name="dh">电话</param>
    ''' <param name="IDimg">身份证正面照片</param>
    ''' <param name="b_l_img">营业执照</param>
    ''' <param name="h_l_img">卫生许可证</param>
    ''' <param name="contractid">合同编号</param>
    ''' <param name="contractimg">合同照片</param>
    ''' <param name="signatory">签约人</param>
    ''' <param name="addpeople">创建人</param>
    ''' <param name="bh">控制总台编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_shop_person_list(ByVal yhbh As Integer, ByVal starsj As String, ByVal endsj As String, ByVal xm As String, ByVal dh As String, ByVal IDimg As String, ByVal b_l_img As String, ByVal h_l_img As String, ByVal contractid As String, ByVal contractimg As String, ByVal signatory As String, ByVal addpeople As String, ByVal bh As Integer) As String
        If IsNumeric(yhbh) = False Then
            Return "用户编号传入不正确，必须是数字"
        End If
        If IsDate(starsj) = False Then
            Return "开始时间传入有误"
        End If
        If IsDate(endsj) = False Then
            Return "结束时间传入有误"
        End If
        If xm = "" Then
            Return "店主姓名不能为空"
        End If
        If xm.Length > 10 Then
            Return "店主姓名字符长度不能超过10个"
        End If
        Dim jcxm As String = ym.aqjc(xm)
        If jcxm <> "" Then
            Return "店主姓名中不能有特殊字符" & jcxm
        End If
        If dh = "" Then
            Return "电话不能为空"
        End If
        If dh.Length > 13 Then
            Return "电话字符长度不能超过13个字符"
        End If
        Dim jcdh As String = ym.aqjc(dh)
        If jcdh <> "" Then
            Return "联系电话中不能有特殊字符" & jcdh
        End If
        If IDimg = "" Then
            Return "请选择店主身份证照片"
        End If
        If IDimg.Length > 200 Then
            Return "图片地址存储路径长度违规"
        End If
        If b_l_img = "" Then
            Return "请上传营业执照图片"
        End If
        If b_l_img.Length > 200 Then
            Return "营业执照地址存储图片路径违规"
        End If
        If contractid = "" Then
            Return "请填写合同编号"
        End If
        If contractid.Length > 50 Then
            Return "合同编号字符长度不能超过50位"
        End If
        Dim jccontractid As String = ym.aqjc(contractid)
        If jccontractid <> "" Then
            Return "合同编号中不能有特殊字符" & jccontractid
        End If
        If contractimg = "" Then
            Return "请上传合同照片"
        End If
        If contractimg.Length > 200 Then
            Return "合同照片存储路径字符长度违规"
        End If
        If signatory = "" Then
            Return "请填写签约人姓名"
        End If
        If signatory.Length > 10 Then
            Return "签约人姓名字符长度不能超过10个字符"
        End If
        Dim jcsignatory As String = ym.aqjc(signatory)
        If jcsignatory <> "" Then
            Return "签约人姓名总不能含有特殊字符" & jcsignatory
        End If
        If addpeople = "" Then
            Return "创建人姓名不能为空"
        End If
        If addpeople.Length > 10 Then
            Return "创建人姓名字符长度不能超过10位"
        End If
        'ByVal yhbh As Integer, ByVal starsj As String, ByVal endsj As String, ByVal xm As String, ByVal dh As String, ByVal IDimg As String, ByVal b_l_img As String, ByVal contractid As String, ByVal contractimg As String, ByVal signatory As String, ByVal addpeople As String, ByVal bh As Integer
        Dim db As New mysjk("Systemk")
        Dim str As String = "update shop_person_list set user_bh=" & yhbh & ",star_sj='" & starsj & "',end_sj='" & endsj & "',xm='" & xm & "',dh='" & dh & "',ID_img='" & IDimg & "',business_license_img='" & b_l_img & "',hygiene_license_img='" & h_l_img & "',contract_id='" & contractid & "'，donreact_img='" & contractimg & "',signatory='" & signatory & "',add_people='" & addpeople & "'"
        str &= " where bh=" & bh
        Dim zx As Integer = db.zx1(str)
        If db.exerr <> "" Then
            Return "修改商铺信息录入失败"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取单条信息
    ''' </summary>
    ''' <param name="bh">店铺控制总台编号</param>
    ''' <returns>操作完成后返回表，失败返回Nothing</returns>
    ''' <remarks></remarks>
    Public Function read_shop_person(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from shop_person_list where bh=" & bh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function

#End Region
#Region "店铺设置"
    '
    ''' <summary>
    ''' 封装店铺
    ''' </summary>
    ''' <param name="yhbh">用户库编号</param>
    ''' <param name="contracts">店铺联系人</param>
    ''' <param name="phone">店铺联系电话</param>
    ''' <param name="address">店铺地址</param>
    ''' <param name="receivablestype">收款方式</param>
    ''' <param name="accountnumber">收款账号</param>
    ''' <param name="payee">收款人姓名</param>
    ''' <param name="onefl">一级分类</param>
    ''' <param name="twofl">二级分类</param>
    ''' <param name="shop_type">商品类型</param>
    ''' <param name="describe">描述</param>
    ''' <param name="top_img">头部图片</param>
    ''' <param name="QRcode_img">二维码图片</param>
    ''' <param name="shopmc">店铺名称</param>
    ''' <param name="tradingarea">商圈</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_shop(ByVal yhbh As Integer, ByVal contracts As String, ByVal phone As String, ByVal address As String, ByVal receivablestype As String, ByVal accountnumber As String, ByVal payee As String, ByVal onefl As String, ByVal twofl As String, ByVal shop_type As Integer, ByVal describe As String, ByVal top_img As String, ByVal QRcode_img As String, ByVal shopmc As String, ByVal tradingarea As String) As String
        If IsNumeric(yhbh) = False Then
            Return "用户编号必须是数字"
        End If
        If contracts = "" Then
            Return "请填写店铺联系人"
        End If
        If contracts.Length > 20 Then
            Return "店铺联系人姓名字符长度不能超过20个"
        End If
        Dim jccontracts As String = ym.aqjc(contracts)
        If jccontracts <> "" Then
            Return "店铺联系人姓名中不能有特殊字符" & jccontracts
        End If
        If phone = "" Then
            Return "联系电话不能为空"
        End If
        Dim jcphone As String = ym.aqjc(phone)
        If jcphone <> "" Then
            Return "联系电话中不能有特殊字符" & jcphone
        End If
        If address = "" Then
            Return "请填店铺地址"
        End If
        Dim jcaddress As String = ym.aqjc(address)
        If jcaddress <> "" Then
            Return "店铺地址中不能有特殊字符" & jcaddress
        End If
        If receivablestype = "" Then
            Return "请填写收款账号归属（如:账号属于支付宝，请填写支付宝）"
        End If
        If accountnumber = "" Then
            Return "请填写收款账号"
        End If
        If payee = "" Then
            Return "请填写收款人姓名"
        End If
        If onefl = "" Then
            Return "请选择商铺所属类目"
        End If
        If twofl = "" Then
            Return "请选择商铺所属二级类目"
        End If
        If IsNumeric(shop_type) = False Then
            Return "店铺类型必须是数字"
        End If
        If top_img = "" Then
            Return "请上传商铺顶部图片"
        End If
        If QRcode_img = "" Then
            Return "请上传二维码图片"
        End If
        If shopmc = "" Then
            Return "请填写店铺名称"
        End If
        If shopmc.Length > 50 Then
            Return "店铺名称字符长度不能超过50个"
        End If
        Dim jcshopmc As String = ym.aqjc(shopmc)
        If jcshopmc <> "" Then
            Return "店铺名称中不能有特殊字符" & jcshopmc
        End If
        If tradingarea = "" Then
            Return "请选择商圈"
        End If

        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into shop_set_up_list (user_bh,contacts,phone,address,receivables_type,account_number.payee,one_classification,two_classification,shop_type,describe,top_img,sj,QR_code_img,shopmc,tradingarea) "
        str &= "values(" & yhbh & ",'" & contracts & "','" & phone & "','" & address & "','" & receivablestype & "','" & accountnumber & "','" & payee & "','" & onefl & "','" & twofl & "'," & shop_type & ",'" & describe & "','" & top_img & "','" & Now & "','" & QRcode_img & "','" & shopmc & "','" & tradingarea & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "创建店铺失败，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改店铺信息
    ''' </summary>  
    ''' <param name="bh">编号</param>
    ''' <param name="yhbh">用户编号</param>
    ''' <param name="contracts">店铺联系人</param>
    ''' <param name="phone">联系电话</param>
    ''' <param name="address">店铺地址</param>
    ''' <param name="receivablestype">收款方式</param>
    ''' <param name="accountnumber">收款账号</param>
    ''' <param name="payee">收款人账号</param>
    ''' <param name="onefl">一级分类</param>
    ''' <param name="twofl">二级分类</param>
    ''' <param name="shop_type">店铺类型</param>
    ''' <param name="describe">描述</param>
    ''' <param name="top_img">头部图片</param>
    ''' <param name="QRcode_img">二维码图片</param>
    ''' <param name="shopmc">店铺名称</param>
    ''' <param name="tradingarea">商圈</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_shop(ByVal bh As Integer, ByVal yhbh As Integer, ByVal contracts As String, ByVal phone As String, ByVal address As String, ByVal receivablestype As String, ByVal accountnumber As String, ByVal payee As String, ByVal onefl As String, ByVal twofl As String, ByVal shop_type As Integer, ByVal describe As String, ByVal top_img As String, ByVal QRcode_img As String, ByVal shopmc As String, ByVal tradingarea As String) As String
        If IsNumeric(yhbh) = False Then
            Return "用户编号必须是数字"
        End If
        If contracts = "" Then
            Return "请填写店铺联系人"
        End If
        If contracts.Length > 20 Then
            Return "店铺联系人姓名字符长度不能超过20个"
        End If
        Dim jccontracts As String = ym.aqjc(contracts)
        If jccontracts <> "" Then
            Return "店铺联系人姓名中不能有特殊字符" & jccontracts
        End If
        If phone = "" Then
            Return "联系电话不能为空"
        End If
        Dim jcphone As String = ym.aqjc(phone)
        If jcphone <> "" Then
            Return "联系电话中不能有特殊字符" & jcphone
        End If
        If address = "" Then
            Return "请填店铺地址"
        End If
        Dim jcaddress As String = ym.aqjc(address)
        If jcaddress <> "" Then
            Return "店铺地址中不能有特殊字符" & jcaddress
        End If
        If receivablestype = "" Then
            Return "请填写收款账号归属（如:账号属于支付宝，请填写支付宝）"
        End If
        If accountnumber = "" Then
            Return "请填写收款账号"
        End If
        If payee = "" Then
            Return "请填写收款人姓名"
        End If
        If onefl = "" Then
            Return "请选择商铺所属类目"
        End If
        If twofl = "" Then
            Return "请选择商铺所属二级类目"
        End If
        If IsNumeric(shop_type) = False Then
            Return "店铺类型必须是数字"
        End If
        If top_img = "" Then
            Return "请上传商铺顶部图片"
        End If
        If QRcode_img = "" Then
            Return "请上传二维码图片"
        End If
        If shopmc = "" Then
            Return "请填写店铺名称"
        End If
        If shopmc.Length > 50 Then
            Return "店铺名称字符长度不能超过50个"
        End If
        Dim jcshopmc As String = ym.aqjc(shopmc)
        If jcshopmc <> "" Then
            Return "店铺名称中不能有特殊字符" & jcshopmc
        End If
        If tradingarea = "" Then
            Return "请选择商圈"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update shop_person_list set user_bh='" & yhbh & "',contacts='" & contracts & "',phone='" & phone & "',address='" & address & "',receivables_type='" & receivablestype & "',account_number='" & accountnumber & "',payee='" & payee & "',one_classification='" & onefl & "',two_classification='" & twofl & "',"
        str &= "shop_type=" & shop_type & ",describe='" & describe & "',top_img='" & top_img & "',QR_code_img='" & QRcode_img & "',shopmc='" & shopmc & "',tradingarea='" & tradingarea & "' where bh=" & bh
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改店铺资料出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取单条商铺信息
    ''' </summary>
    ''' <param name="bh">用户编号</param>
    ''' <returns>操作完成返回表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_one_shop(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from shop_set_up where bh=" & bh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
#End Region
#Region "类目"
    '一级类目
    '
    ''' <summary>
    ''' 插入一级类目分类
    ''' </summary>
    ''' <param name="name">类目名称</param>
    ''' <param name="img">类目图标</param>
    ''' <param name="numbersort">排序</param>
    ''' <returns>操作完成返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_one_classification(ByVal name As String, ByVal img As String, ByVal numbersort As Integer) As String
        If name = "" Then
            Return "请填写一级类目名称"
        End If
        If name.Length > 50 Then
            Return "一级类目名称字符长度不能超过50个"
        End If
        Dim jcname As String = ym.aqjc(name)
        If jcname <> "" Then
            Return "一级类目中不能有特殊字符" & jcname
        End If
        If img = "" Then
            Return "请增加一级类目图标"
        End If
        If img.Length > 200 Then
            Return "一级记录图标字符长度不能超过200个字符"
        End If
        If IsNumeric(numbersort) = False Then
            Return "排序使用的编号必须是设置"
        End If

        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into classification_one (name,img,number_sort) "
        str &= "values('" & name & "','" & img & "'," & numbersort & ")"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "创建一级类目出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改一级类目
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <param name="name">一级类目名称</param>
    ''' <param name="img">一级类目的图片</param>
    ''' <param name="numbersort">排序</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function edit_one_classification(ByVal bh As Integer, ByVal name As String, ByVal img As String, ByVal numbersort As Integer) As String
        If IsNumeric(bh) = False Then
            Return "分类编号必须是数字"
        End If
        If name = "" Then
            Return "请填写一级类目名称"
        End If
        If name.Length > 50 Then
            Return "一级类目名称字符长度不能超过50个"
        End If
        Dim jcname As String = ym.aqjc(name)
        If jcname <> "" Then
            Return "一级类目中不能有特殊字符" & jcname
        End If
        If img = "" Then
            Return "请增加一级类目图标"
        End If
        If img.Length > 200 Then
            Return "一级记录图标字符长度不能超过200个字符"
        End If
        If IsNumeric(numbersort) = False Then
            Return "排序使用的编号必须是设置"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update classification_one set name='" & name & "',img='" & img & "',number_sort=" & numbersort & " where bh=" & bh

        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改一级类目出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 删除一级类目
    ''' </summary>
    ''' <param name="bh">用户编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_one_classfication(ByVal bh As Integer) As String
        Dim db As New mysjk("Systemk")
        Dim tb As DataTable = Nothing
        Dim str As String
        str = "select * from classification_two where one_bh=" & bh
        tb = db.dqb(str)
        If tb.Rows.Count > 0 Then
            str = "delete from classification_two where one_bh=" & bh
            If db.zx1(str) < 0 Then

                Return "删除一级类目出错，请重新尝试"
            End If
        Else
            If db.zx1("delete from classification_one where bh=" & bh) < 0 Then
                Return "无法完成删除一级类目的操作，请联系网站管理员"
            End If
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取单条类目
    ''' </summary>
    ''' <param name="bh">一级类目编号</param>
    ''' <returns>操作完成返回表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_one_classification(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from classification where bh=" & bh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function

    '
    ''' <summary>
    ''' 二级类目
    ''' </summary>
    ''' <param name="onebh">一级类目编号</param>
    ''' <param name="name">二级类目名称</param>
    ''' <param name="img">图片</param>
    ''' <param name="numbersort">支持</param>
    ''' <returns>操作成功后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_two_classification(ByVal onebh As Integer, ByVal name As String, ByVal img As String, ByVal numbersort As String) As String
        If IsNumeric(onebh) = False Then
            Return "分类编号必须是数字"
        End If
        If name = "" Then
            Return "请填写二级类目名称"
        End If
        If name.Length > 50 Then
            Return "二级类目名称字符长度不能超过50个"
        End If
        Dim jcname As String = ym.aqjc(name)
        If jcname <> "" Then
            Return "二级类目中不能有特殊字符" & jcname
        End If
        If img = "" Then
            Return "请增加二级类目图标"
        End If
        If img.Length > 200 Then
            Return "二级记录图标字符长度不能超过200个字符"
        End If
        If IsNumeric(numbersort) = False Then
            Return "排序使用的编号必须是设置"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into classification_two (one_bh,name,img,number_sort) "
        str &= "values(" & onebh & ",'" & name & "','" & img & "'," & numbersort & ")"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "创建二级类目出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改二级类目
    ''' </summary>
    ''' <param name="bh">二级类目编号</param>
    ''' <param name="onebh">一级类目编号</param>
    ''' <param name="name">二级类目名称</param>
    ''' <param name="img">二级类目图片</param>
    ''' <param name="numbersort">排序</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_two_classification(ByVal bh As Integer, ByVal onebh As Integer, ByVal name As String, ByVal img As String, ByVal numbersort As String) As String
        If IsNumeric(onebh) = False Then
            Return "分类编号必须是数字"
        End If
        If name = "" Then
            Return "请填写二级类目名称"
        End If
        If name.Length > 50 Then
            Return "二级类目名称字符长度不能超过50个"
        End If
        Dim jcname As String = ym.aqjc(name)
        If jcname <> "" Then
            Return "二级类目中不能有特殊字符" & jcname
        End If
        If img = "" Then
            Return "请增加二级类目图标"
        End If
        If img.Length > 200 Then
            Return "二级记录图标字符长度不能超过200个字符"
        End If
        If IsNumeric(numbersort) = False Then
            Return "排序使用的编号必须是设置"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update classification_two set one_bh=" & onebh & ",name='" & name & "',img='" & img & "',number_sort=" & numbersort & " where bh=" & bh

        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改二级类目出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取二级类目
    ''' </summary>
    ''' <param name="bh">二级类目</param>
    ''' <param name="onebh">一级类目编号</param>
    ''' <returns>操作完成后返回表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_two_classification(ByVal bh As Integer, ByVal onebh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        If bh = 0 Then
            str = "select * from classification_two where one_bh=" & onebh
        Else
            str = "select top 1 * from classification_two where bh=" & bh & " and one_bh=" & onebh
        End If
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 删除二级类目
    ''' </summary>
    ''' <param name="bh">二级类目编号</param>
    ''' <returns>操作完成返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_two_classification(ByVal bh As Integer) As String
        Dim db As New mysjk("Systemk")
        Dim str As String = "delete from classification_two where bh=" & bh
        If db.zx1(str) < 0 Then
            Return "无法完成删除此类目的操作，请联系网站管理员。"
        End If
        Return ""
    End Function
#End Region
#Region "银行"
    '
    ''' <summary>
    ''' 插入银行
    ''' </summary>
    ''' <param name="mc">银行名称</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function add_bank(ByVal mc As String) As String
        If mc = "" Then
            Return "银行名称不能为空"
        End If
        If mc.Length > 100 Then
            Return "银行名称字符长度不能超过100"
        End If
        Dim jcmc As String = ym.aqjc(mc)
        If jcmc <> "" Then
            Return "银行名称字符中不能有特殊字符" & jcmc
        End If

        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into bank_list (name) "
        str &= "values('" & mc & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "增加银行名出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改银行
    ''' </summary>
    ''' <param name="bh">银行库编号</param>
    ''' <param name="mc">银行名称</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function edit_bank(ByVal bh As Integer, ByVal mc As String) As String
        If IsNumeric(bh) = False Then
            Return "银行名称编号必须是数字"
        End If
        If mc = "" Then
            Return "银行名称不能为空"
        End If
        If mc.Length > 100 Then
            Return "银行名称字符长度不能超过100"
        End If
        Dim jcmc As String = ym.aqjc(mc)
        If jcmc <> "" Then
            Return "银行名称字符中不能有特殊字符" & jcmc
        End If

        Dim db As New mysjk("Systemk")
        Dim str As String = "update bank_list set name='" & mc & "' where bh=" & bh
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改银行名出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 查看银行
    ''' </summary>
    ''' <param name="bh">银行编号</param>
    ''' <returns>操作完成后返回表，操作失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_bank(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        If bh = 0 Then
            str = "select * from bank_list"
        Else
            str = "select top 1 * from bank_list where bh=" & bh
        End If
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 删除银行
    ''' </summary>
    ''' <param name="bh">银行库编号</param>
    ''' <returns>操作完成返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_bank(ByVal bh As Integer) As String
        Dim db As New mysjk("Systemk")
        Dim str As String = "delete from bank_list where bh=" & bh
        If db.zx1(str) < 0 Then
            Return "无法完成删除此银行名称的操作，请联系网站管理员。"
        End If
        Return ""
    End Function
#End Region
#Region "订单"
    '
    ''' <summary>
    ''' 插入订单
    ''' </summary>
    ''' <param name="user_bh">银行库编号</param>
    ''' <param name="order_id">订单编号-18位</param>
    ''' <param name="commodityimg">商品编号</param>
    ''' <param name="title">商品名称</param>
    ''' <param name="endsj">开始时间</param>
    ''' <param name="startsj">结束时间</param>
    ''' <param name="usersj">使用时间</param>
    ''' <param name="actualpayje">实付金额</param>
    ''' <param name="integralje">实付积分</param>
    ''' <param name="fl_">分类</param>
    ''' <param name="actualje">实金额</param>
    ''' <param name="zt">状态</param>
    ''' <param name="shopid">商家编号</param>
    ''' <param name="commodytybh">商品编号</param>
    ''' <param name="number">数量</param>
    ''' <param name="oneprice">单价</param>
    ''' <param name="delzt">删除状态</param>
    ''' <param name="paytype">支付方式</param>
    ''' <param name="payaccpunt">付款账户</param>
    ''' <returns>操作完成返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_order_list(ByVal user_bh As Integer, ByVal order_id As String, ByVal commodityimg As String, ByVal title As String, ByVal endsj As String, ByVal startsj As String, ByVal usersj As String, ByVal actualpayje As Double, ByVal integralje As Integer, ByVal fl_ As Integer, ByVal actualje As Double, ByVal zt As Integer, ByVal shopid As Integer, ByVal commodytybh As Integer, ByVal number As Integer, ByVal oneprice As String, ByVal delzt As Integer, ByVal paytype As String, ByVal payaccpunt As String) As String
        If IsNumeric(user_bh) = False Then
            Return "用户编号必须是数字"
        End If
        If order_id = "" Then
            Return "订单编号不能为空"
        End If
        If order_id.Length > 50 Then
            Return "订单编号字符长度不能超过50个"
        End If
        Dim jcorder As String = ym.aqjc(order_id)
        If jcorder <> "" Then
            Return "订单编号中不能有特殊字符" & jcorder
        End If
        If commodityimg = "" Then
            Return "请上传商品图片"
        End If
        If commodityimg.Length > 200 Then
            Return "商品图片字符长度不能超过200字符"
        End If
        If title = "" Then
            Return "订单的商品标题不能为空"
        End If
        If title.Length > 20 Then
            Return "订单的商品标题字符长度不能超过20个"
        End If
        Dim jctitle As String = ym.aqjc(title)
        If jctitle <> "" Then
            Return "订单的商品标题中不能有特殊字符" & jctitle
        End If
        If endsj = "" Then
            Return "请填写结束时间"
        End If
        Dim jcendsj As String = ym.aqjc(endsj)
        If jcendsj <> "" Then
            Return "结束时间中不能有特殊字符" & jcendsj
        End If
        If startsj = "" Then
            Return "请填写创建时间"
        End If
        Dim jcstartsj As String = ym.aqjc(startsj)
        If jcstartsj <> "" Then
            Return "创建订单时间中不能有特殊字符" & jcstartsj
        End If
        If usersj <> "" Then
            If IsDate(usersj) = False Then
                Return "使用时间日期出错"
            End If
        End If
        If actualpayje = "" Then
            Return "请填写实付金额"
        End If
        If ym.testfloat(actualpayje) = False Then
            Return "金额填写不符合规则"
        End If
        If IsNumeric(integralje) = False Then
            Return "实付积分传值不正确"
        End If
        If IsNumeric(fl_) = False Then
            Return "交易分类传值必须是数字"
        End If

        If ym.testfloat(actualje) = False Then
            Return "请传入商品总价"
        End If
        If IsNumeric(zt) = False Then
            Return "请传入订单状态"
        End If
        If IsNumeric(shopid) = False Then
            Return "请传入商家编号"
        End If
        If IsNumeric(commodytybh) = False Then
            Return "请上传商品编号"
        End If
        If IsNumeric(number) = False Then
            Return "请传入购买的商品数量"
        End If
        If oneprice = "" Then
            Return "请传入商品的单价"
        End If
        If ym.testfloat(oneprice) = False Then
            Return "传入的商品单价不符合规则"
        End If
        If IsNumeric(delzt) = False Then
            Return "传入的删除状态不正确"
        End If
        If paytype = "" Then
            Return "请传入支付方式"
        End If

        Dim jcpaytype As String = ym.aqjc(paytype)
        If jcpaytype <> "" Then
            Return "支付方式中不能有特殊字符" & jcpaytype
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into order_list (user_bh,order_id,commodity_img,title,end_sj,start_sj,user_sj,actual_pay_je,integral_je,fl,actual_je,zt,shop_id,commodity_bh，Number,one_price,del_zt,pay_type,pay_account) "
        str &= "values(" & user_bh & ",'" & order_id & "','" & commodityimg & "','" & title & "','" & endsj & "','" & startsj & "','" & usersj & "','" & actualpayje & "'," & integralje & "," & fl_ & ",'" & actualje & "'," & zt & "," & shopid & "," & commodytybh & "," & number & ",'" & oneprice & "'," & delzt & ",'" & paytype & "','" & payaccpunt & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "写入订单列表出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 查询订单-单条查询-可以用来检测订单编号
    ''' </summary>
    ''' <param name="orderid">订单编号-18位字符</param>
    ''' <returns>操作完成后返回一个表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_one_order(ByVal orderid As String) As DataTable
        If orderid = "" Then
            Return Nothing
        End If
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from order_list where order_id='" & orderid & "'"
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 商品编号查询订单库，查询销量
    ''' </summary>
    ''' <param name="commoditybh">商品编号</param>
    ''' <returns>操作完成后返回数量</returns>
    ''' <remarks></remarks>
    Public Function commodity_find_order(ByVal commoditybh As Integer) As String
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from order_list where commodity_bh=" & commoditybh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return ""
        End If
        Return tb.Rows.Count
    End Function
#End Region
#Region "订单密钥表"
    '
    ''' <summary>
    ''' 密钥查询
    ''' </summary>
    ''' <param name="key">传入密钥</param>
    ''' <returns>检测密钥是否存在，不存在返回空值</returns>
    ''' <remarks></remarks>
    Public Function find_key(ByVal key As String) As String
        If key = "" Then
            Return "请传入要验证的密钥码"
        End If
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from secret_key where key_secret='" & key & "'"
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return erro
        End If
        If tb.Rows.Count > 0 Then
            Return "密钥已存在"
        Else
            Return ""
        End If
    End Function
    '
    ''' <summary>
    ''' 密钥合成输出
    ''' </summary>
    ''' <returns>输出密钥</returns>
    ''' <remarks></remarks>
    Function made_key() As String
        Dim key_Rd As New Random()
        Dim key_str_left As Integer = key_Rd.Next(1000, 9999)
        Dim key_str_mid As Integer = key_Rd.Next(1000, 9999)
        Dim key_str_right As Integer = key_Rd.Next(1000, 9999)
        Dim key_all As String = key_str_left & key_str_mid & key_str_right
        Return key_all
    End Function
    '
    ''' <summary>
    ''' 把密钥插入数据库
    ''' </summary>
    ''' <param name="orderbh"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function return_key(ByVal orderbh As Integer) As String
        If IsNumeric(orderbh) = False Then
            Return "请传入订单库编号"
        End If
        Dim key_word As String = made_key()
        Dim jckey As String = find_key(key_word)
        While jckey = ""
            key_word = made_key()
            jckey = find_key(key_word)
            'If jckey = "密钥已存在" Then
            '    jckey = find_key(made_key())
            'Else
            '    key_word = jckey
            'End If
        End While
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into secret_key (order_bh,key_secret) "
        str &= "values(" & orderbh & ",'" & key_word & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "写入密钥库失败，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改使用状态-商铺使用
    ''' </summary>
    ''' <param name="key_">密钥</param>
    ''' <param name="zt">状态</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function edit_key(ByVal key_ As String, ByVal zt As Integer) As String
        Dim return_str As String = find_key(key_)
        If return_str = "" Then
            Return "您输入的验证密钥不存在"
        End If
        If return_str <> "密钥已存在" Then
            Return "检测密钥程序出错"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = ""

        str = "select top 1 * from secret_key where key_secret='" & key_ & "'"
        Dim tb As DataTable = db.dqb(str)
        If db.exerr <> "" Then
            Return db.exerr
        End If
        If tb.Rows(0)("zt") = 1 Then
            Return "密钥已使用"
        End If
        str = "update secret_key set zt=" & zt & " where key_secret='" & key_ & "'"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改密钥使用状态出错，请联系程序员调试"
        End If
        Try
            zx = db.zx1("update order_list set zt=" & zt & " where bh=" & tb.Rows(0)("order_bh"))
            If zx < 0 Then
                Return "修改订单状态出错，请联系程序员调试"
            End If
        Catch ex As Exception
            str = "update secret_key set zt=0 where key_secret='" & key_ & "'"
            zx = db.zx1(str)
            If zx < 0 Then
                Return "恢复密钥状态出错，请联系技术部"
            End If
        End Try
        Return ""
    End Function

#End Region
#Region "充值记录"
    '
    ''' <summary>
    ''' 新增数据
    ''' </summary>
    ''' <param name="userbh">用户库编号</param>
    ''' <param name="paymoney">充值金额</param>
    ''' <param name="paytype">充值方式</param>
    ''' <param name="payaccount">充值付款账户</param>
    ''' <param name="integral">充值赠送的积分</param>
    ''' <param name="zt">充值状态</param>
    ''' <param name="rechargeid">支付宝或者微信返回值</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_recharge(ByVal userbh As Integer, ByVal paymoney As Single, ByVal paytype As String, ByVal payaccount As String, ByVal integral As Integer, ByVal zt As Integer, ByVal rechargeid As String) As String
        If IsNumeric(userbh) = False Then
            Return "用户编号传入不正确"
        End If
        If ym.testfloat(paymoney) = False Then
            Return "传入的充值金额违规"
        End If
        If paytype = "" Then
            Return "请传入充值使用的银行名称"
        End If
        If payaccount = "" Then
            Return "请传入充值账号"
        End If
        If payaccount.Length > 100 Then
            Return "充值账号传入违规"
        End If
        Dim jcpayaccount As String = ym.aqjc(payaccount)
        If jcpayaccount <> "" Then
            Return "传入的支付账号中不要有特殊字符" & jcpayaccount
        End If
        If IsNumeric(integral) = False Then
            Return "传入的积分字符格式违规"
        End If
        If IsNumeric(zt) = False Then
            Return "状态传入值不符合规则"
        End If
        If rechargeid = "" Then
            Return "充值返回的id不能是空"
        End If
        If rechargeid.Length > 100 Then
            Return "充值返回的id字符长度不能超过100个字符"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into recharge_list (user_bh,pay_money,pay_type,pay_account,integral,zt,sj,recharge_id) "
        str &= "values(" & userbh & ",'" & paymoney & "','" & paytype & "','" & payaccount & "'," & integral & "," & zt & "," & Now & ",'" & rechargeid & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "写入充值库失败，请联系程序员调试"
        End If
        Return ""
    End Function
    '
#End Region
#Region "商品"
    '
    ''' <summary>
    ''' 上传商品
    ''' </summary>
    ''' <param name="activitybh">活动库编号</param>
    ''' <param name="activitybln">是否参加活动</param>
    ''' <param name="activitymoney">活动收益</param>
    ''' <param name="shopbh">店铺编号</param>
    ''' <param name="title">商品编号</param>
    ''' <param name="pchome_list_img">首页封面缩略图</param>
    ''' <param name="pageimg">商品页面头图</param>
    ''' <param name="apphomeimg">手机端封面图</param>
    ''' <param name="sketch">简诉</param>
    ''' <param name="originalprice">原价格</param>
    ''' <param name="currentprice">现价格</param>
    ''' <param name="reward">积分奖励</param>
    ''' <param name="integralprice">积分价格</param>
    ''' <param name="needintegral">补加积分</param>
    ''' <param name="endsj">结束时间</param>
    ''' <param name="content_">内容描述</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_commodity(ByVal activitybh As Integer, ByVal activitybln As Integer, ByVal activitymoney As Double, ByVal shopbh As Integer, ByVal pchome_list_img As String, ByVal pageimg As String, ByVal apphomeimg As String, ByVal title As String, ByVal sketch As String, ByVal originalprice As Single, ByVal currentprice As Single, ByVal reward As Integer, ByVal integralprice As Single, ByVal needintegral As Integer, ByVal endsj As String, ByVal content_ As String) As String
        If IsNumeric(activitybh) = False Then
            Return "请上传活动编号"
        End If
        If IsNumeric(activitybln) = False Then
            Return "是否参加活动传入的boolen型字符有误"
        End If
        If ym.testfloat(activitymoney) = False Then
            Return "活动收益金额传入违规"
        End If
        If IsNumeric(shopbh) = False Then
            Return "传入的商户编号不符合规则"
        End If
        If title = "" Then
            Return "请传入商家标题"
        End If
        If title.Length > 20 Then
            Return ""
        End If
        If pchome_list_img = "" Then
            Return "请上传首页封面图"
        End If
        If pchome_list_img.Length > 200 Then
            Return "首页封面图字符长度不能超过200个字符"
        End If
        If pageimg = "" Then
            Return "请上传商品首页头图"
        End If
        If pageimg.Length > 200 Then
            Return "商品首页头图字符长度不能超过200个字符"
        End If
        If apphomeimg = "" Then
            Return "请上传手机封面头图"
        End If
        If apphomeimg.Length > 200 Then
            Return "手机封面头图字符长度不能超过200个"
        End If
        Dim jctitile As String = ym.aqjc(title)
        If jctitile <> "" Then
            Return "输入的商家标题上不能有特殊字符" & jctitile
        End If
        If sketch = "" Then
            Return "商品简述不能为空"
        End If
        If sketch.Length > 100 Then
            Return "商品简述字符不能超过100个"
        End If
        Dim jcsketch As String = ym.aqjc(sketch)
        If jcsketch <> "" Then
            Return "商品简述中不能有特殊字符" & jcsketch
        End If
        If ym.testfloat(originalprice) = False Then
            Return "价格传入不符合规则"
        End If
        If ym.testfloat(currentprice) = False Then
            Return "现价格传入不符合规则"
        End If
        If IsNumeric(reward) = False Then
            Return "积分传入必须是数字"
        End If
        If ym.testfloat(integralprice) = False Then
            Return "输入的积分价格违规"
        End If
        If endsj = "" Then
            Return "请输入结束时间"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into commodity_list (activity_bh,activity_bln,activity_money,shop_bh,pc_home_list_img,page_img,app_home_img,title,sketch,Original_price,Current_price,reward,integral_price,need_integral,end_sj,Content_,zt_shop,zt_admin,sj) "
        str &= "values(" & activitybh & "," & activitybln & ",'" & activitymoney & "'," & shopbh & ",'" & pchome_list_img & "','" & pageimg & "','" & apphomeimg & "','" & title & "','" & sketch & "','" & originalprice & "','" & currentprice & "'," & reward & ",'" & integralprice & "'," & needintegral & ",'" & endsj & "','" & content_ & "',1,1,'" & Now & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "写入商品库失败，请联系程序员调试"
        End If
        Return ""
    End Function
    '修改商品信息
    ''' <summary>
    ''' 修改商品信息
    ''' </summary>
    ''' <param name="activitybh">活动库编号</param>
    ''' <param name="activitybln">是否参加活动</param>
    ''' <param name="activitymoney">活动收益</param>
    ''' <param name="shopbh">店铺编号</param>
    ''' <param name="title">商品编号</param>
    ''' <param name="pchome_list_img">首页封面缩略图</param>
    ''' <param name="pageimg">商品页面头图</param>
    ''' <param name="apphomeimg">手机端封面图</param>
    ''' <param name="sketch">简诉</param>
    ''' <param name="originalprice">原价格</param>
    ''' <param name="currentprice">现价格</param>
    ''' <param name="reward">积分奖励</param>
    ''' <param name="integralprice">积分价格</param>
    ''' <param name="needintegral">补加积分</param>
    ''' <param name="endsj">结束时间</param>
    ''' <param name="content_">内容描述</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_commodity(ByVal activitybh As Integer, ByVal activitybln As Integer, ByVal activitymoney As Double, ByVal bh As Integer, ByVal shopbh As Integer, ByVal pchome_list_img As String, ByVal pageimg As String, ByVal apphomeimg As String, ByVal title As String, ByVal sketch As String, ByVal originalprice As Single, ByVal currentprice As Single, ByVal reward As Integer, ByVal integralprice As Single, ByVal needintegral As Integer, ByVal endsj As String, ByVal content_ As String, ByVal ztshop As Integer, ByVal ztadmin As Integer) As String
        If IsNumeric(activitybh) = False Then
            Return "请上传活动编号"
        End If
        If IsNumeric(activitybln) = False Then
            Return "是否参加活动传入的boolen型字符有误"
        End If
        If ym.testfloat(activitymoney) = False Then
            Return "活动收益金额传入违规"
        End If
        If IsNumeric(bh) = False Then
            Return "编号传值出错"
        End If
        If IsNumeric(shopbh) = False Then
            Return "传入的商户编号不符合规则"
        End If
        If title = "" Then
            Return "请传入商家标题"
        End If
        If title.Length > 20 Then
            Return ""
        End If
        Dim jctitile As String = ym.aqjc(title)
        If jctitile <> "" Then
            Return "输入的商家标题上不能有特殊字符" & jctitile
        End If
        If sketch = "" Then
            Return "商品简述不能为空"
        End If
        If sketch.Length > 100 Then
            Return "商品简述字符不能超过100个"
        End If
        Dim jcsketch As String = ym.aqjc(sketch)
        If jcsketch <> "" Then
            Return "商品简述中不能有特殊字符" & jcsketch
        End If
        If ym.testfloat(originalprice) = False Then
            Return "价格传入不符合规则"
        End If
        If ym.testfloat(currentprice) = False Then
            Return "现价格传入不符合规则"
        End If
        If IsNumeric(reward) = False Then
            Return "积分传入必须是数字"
        End If
        If ym.testfloat(integralprice) = False Then
            Return "输入的积分价格违规"
        End If
        If endsj = "" Then
            Return "请输入结束时间"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update commodity_list set activity_bh=" & activitybh & ",activity_bln=" & activitybln & ",activity_money='" & activitymoney & "',shop_bh=" & shopbh & ",title='" & title & "',sketch='" & sketch & "',Original_price='" & originalprice & "',Current_price='" & currentprice & "',reward=" & reward & ",integral_price='" & integralprice & "',need_integral=" & needintegral & ",end_sj='" & endsj & "',Content_='" & content_ & "',zt_shop=" & ztshop & ",zt_admin=" & ztadmin & " where bh=" & bh

        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改商品信息失败，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改商品状态-管理员
    ''' </summary>
    ''' <param name="bh">商品编号</param>
    ''' <param name="ztshop"></param>
    ''' <param name="ztadmin"></param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function amin_edit_commodity(ByVal bh As Integer, ByVal ztshop As Integer, ByVal ztadmin As Integer) As String
        If IsNumeric(bh) = False Then
            Return "传入的编号不正确"
        End If
        If IsNumeric(ztshop) = False Then
            Return "传入商家编辑商品状态不正确"
        End If
        If IsNumeric(ztadmin) = False Then
            Return "传入管理员修改商品状态不正确"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update commodity_list set zt_shop=" & ztshop & ",zt_admin=" & ztadmin & " where bh=" & bh

        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "管理员修改商品状态失败，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 删除商品信息
    ''' </summary>
    ''' <param name="bh">商品编号</param>
    ''' <returns>操作成功后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_commodity(ByVal bh As Integer) As String
        Dim find_oreder_jg As String = commodity_find_order(bh)
        If find_oreder_jg = "" Then
            Return find_oreder_jg '把错误提示返回出来
        End If
        If CInt(find_oreder_jg) <> 0 Then
            Return "有销售记录的商品将无法删除。"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "delete from commodity_list where bh=" & bh
        If db.zx1(str) < 0 Then
            Return "删除此条商品信息出错，请联系网站管理员。"
        End If
        Return ""
    End Function
#End Region
#Region "评价"
    '
    ''' <summary>
    ''' 插入评价信息
    ''' </summary>
    ''' <param name="userbh">用户编号</param>
    ''' <param name="level_">级别【1差，2一般，3满意，4很满意，5强烈推荐】</param>
    ''' <param name="taste">味道评分【1-5分】</param>
    ''' <param name="environment">环境评分【1-5分】</param>
    ''' <param name="service_">服务评分【1-5】</param>
    ''' <param name="describe_">描述</param>
    ''' <param name="commoditybh">商品编号</param>
    ''' <param name="evaluateimg">图片集【500字符】</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_evaluate_list(ByVal userbh As Integer, ByVal level_ As Integer, ByVal taste As Integer, ByVal environment As Integer, ByVal service_ As Integer, ByVal describe_ As String, ByVal commoditybh As Integer, ByVal evaluateimg As String) As String
        If IsNumeric(userbh) = False Then
            Return "传入的用户编号违规"
        End If
        If IsNumeric(level_) = False Then
            Return "传入的总评分违规"
        End If
        If IsNumeric(taste) = False Then
            Return "传入菜品味道评分违规"
        End If
        If IsNumeric(environment) = False Then
            Return "传入环境评分违规"
        End If
        If IsNumeric(service_) = False Then
            Return "传入环境评分违规"
        End If
        If describe_ <> "" Then
            If describe_.Length > 500 Then
                Return ""
            End If
        End If
        If evaluateimg <> "" Then
            If evaluateimg.Length > 500 Then
                Return "传入的展示图片地址超过限定！"
            End If
        End If
        If IsNumeric(commoditybh) = False Then
            Return "传入商品编号违规"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into evaluate_list (user_bh,level_,taste,environment,service,describe,commondity_bh,zt_addmin,evalate_img,sj) "
        str &= "values(" & userbh & "," & level_ & "," & taste & "," & environment & "," & service_ & ",'" & describe_ & "'," & commoditybh & ",1,'" & evaluateimg & "'," & Now & ")"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "写入评价失败，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 编辑评价
    ''' </summary>
    ''' <param name="userbh">用户编号</param>
    ''' <param name="level_">级别【1差，2一般，3满意，4很满意，5强烈推荐】</param>
    ''' <param name="taste">味道评分【1-5分】</param>
    ''' <param name="environment">环境评分【1-5分】</param>
    ''' <param name="service_">服务评分【1-5】</param>
    ''' <param name="describe_">描述</param>
    ''' <param name="commoditybh">商品编号</param>
    ''' <param name="evaluateimg">图片集【500字符】</param>
    ''' <returns>操作成功后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_evaluate(ByVal bh As Integer, ByVal userbh As Integer, ByVal level_ As Integer, ByVal taste As Integer, ByVal environment As Integer, ByVal service_ As Integer, ByVal describe_ As String, ByVal commoditybh As Integer, ByVal evaluateimg As String) As String
        If IsNumeric(bh) = False Then
            Return "传入的评价编号违规"
        End If
        If IsNumeric(userbh) = False Then
            Return "传入的用户编号违规"
        End If
        If IsNumeric(level_) = False Then
            Return "传入的总评分违规"
        End If
        If IsNumeric(taste) = False Then
            Return "传入菜品味道评分违规"
        End If
        If IsNumeric(environment) = False Then
            Return "传入环境评分违规"
        End If
        If IsNumeric(service_) = False Then
            Return "传入环境评分违规"
        End If
        If describe_ <> "" Then
            If describe_.Length > 500 Then
                Return ""
            End If
        End If
        If evaluateimg <> "" Then
            If evaluateimg.Length > 500 Then
                Return "传入的展示图片地址超过限定！"
            End If
        End If
        If IsNumeric(commoditybh) = False Then
            Return "传入商品编号违规"
        End If

        Dim db As New mysjk("Systemk")
        Dim str As String = "update evaluate_list set user_bh=" & userbh & ",level_=" & level_ & ",taste=" & taste & ",environment=" & environment & ",service=" & service_ & ",describe='" & describe_ & "',commondity_bh=" & commoditybh & ",evalate_img='" & evaluateimg & "') "

        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改评价失败，请联系程序员调试"
        End If
        Return ""
    End Function

#End Region
#Region "手机验证码表"
    '
    ''' <summary>
    ''' 插入验证码库
    ''' </summary>
    ''' <param name="phone">手机号</param>
    ''' <param name="code_">验证码</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_phone_code(ByVal phone As String, ByVal code_ As String) As String
        If phone = "" Then
            Return "请传入手机号码"
        End If
        If code_ = "" Then
            Return "请传入验证码"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into evaluate_list (phone,code) "
        str &= "values('" & phone & "','" & code_ & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "写入手机验证码表失败，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 验证手机
    ''' </summary>
    ''' <param name="phone_">手机号</param>
    ''' <param name="code_">返回值</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function test_phone_code(ByVal phone_ As String, ByVal code_ As String) As String
        If phone_ = "" Then
            Return "请传入手机号码"
        End If
        If code_ = "" Then
            Return "请传入验证码"
        End If
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from phone_code_list where phone='" & phone_ & "' order by bh desc,by"
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return erro
        End If
        If tb.Rows.Count > 0 Then
            Return "1"
        Else
            Return "0"
        End If
    End Function
    '
    ''' <summary>
    ''' 随机产生6位
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function return_code() As String
        Dim phonecode As New Random()
        Return phonecode.Next(100000, 999999)
    End Function
#End Region
#Region "城市区县商圈"
    '城市
    ''' <summary>
    ''' 增加城市
    ''' </summary>
    ''' <param name="mc">城市中文名称</param>
    ''' <param name="en">城市拼音-要求全拼</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_city(ByVal mc As String, ByVal en As String) As String
        If mc = "" Then
            Return "请输入城市名称"
        End If
        If mc.Length > 20 Then
            Return "城市名称字符长度不能超过20个"
        End If
        Dim jcmc As String = ym.aqjc(mc)
        If jcmc <> "" Then
            Return "城市名称中不能有特殊字符"
        End If
        If en = "" Then
            Return "请输入城市的拼音"
        End If
        If en.Length > 100 Then
            Return "城市拼音名称格式不正确，字符为1-100位"
        End If
        If ym.aqjc(en) <> "" Then
            Return "城市拼音名称不支持特殊字符" & ym.aqjc(en)
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into city_b (mc,en) values('" & mc & "','" & en & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "插入城市出错，请联系程序员"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取城市
    ''' </summary>
    ''' <param name="bh">城市库编号</param>
    ''' <returns>操作完成后返回表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_city(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        If bh = 0 Then
            str = "select * from city_b order by bh"
        Else
            str = "select top 1 * from city_b where bh=" & bh
        End If
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 修改城市
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <param name="mc">城市名称</param>
    ''' <param name="py_">城市拼音</param>
    ''' <returns>操作成功返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_city(ByVal bh As Integer, ByVal mc As String, ByVal py_ As String) As String
        If IsNumeric(bh) = False Then
            Return "城市编号必须是数字"
        End If
        If mc = "" Then
            Return "城市不能为空"
        End If
        If mc.Length > 20 Then
            Return "城市名称格式不正确，字符为1-20位"
        End If
        If ym.aqjc(mc) <> "" Then
            Return "城市名称不支持特殊字符" & ym.aqjc(mc)
        End If

        If py_ = "" Then
            Return "城市拼音不能为空"
        End If
        If py_.Length > 100 Then
            Return "城市拼音名称格式不正确，您输入的字符过长。"
        End If
        If ym.aqjc(py_) <> "" Then
            Return "城市拼音名称不支持特殊字符" & ym.aqjc(py_)
        End If
        Dim db As New mysjk("Systemk")
        Dim zx As Integer = db.zx1("update city_b set mc='" & mc & "',en='" & py_ & "' where bh=" & bh)
        If zx < 0 Then
            Return "修改城市出错，请联系程序员"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 删除城市
    ''' </summary>
    ''' <param name="bh">城市编号</param>
    ''' <returns>操作成功后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_city(ByVal bh As Integer) As String
        Dim db As New mysjk("Systemk")
        Dim tb As DataTable = Nothing
        Dim str As String
        str = "select * from county_b where citybh=" & bh
        tb = db.dqb(str)
        If tb.Rows.Count > 0 Then
            str = "delete from county_b where citybh=" & bh
            If db.zx1(str) < 0 Then
                Return "删除区县出错，请重新尝试"
            End If
        Else
            If db.zx1("delete from city_b where bh=" & bh) < 0 Then
                Return "删除城市出错"
            End If
        End If
        Return ""
    End Function
    '检测城市拼音
    ''' <summary>
    ''' 检测城市拼音
    ''' </summary>
    ''' <param name="py_">拼音</param>
    ''' <returns>查询到返回Y，未查到返回N</returns>
    ''' <remarks></remarks>
    Public Function jc_citypy(ByVal py_ As String) As String
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from city_b where en='" & py_ & "'"
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return "检测城市拼音出错" '错误
        End If
        If tb.Rows.Count = 0 Then
            Return "N" '没有
        Else
            Return "Y" '已经存在
        End If
    End Function
    '
    ''' <summary>
    ''' 拼音读取城市
    ''' </summary>
    ''' <param name="py_">城市拼音</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function pydq_city(ByVal py_ As String) As String
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from city_b where py='" & py_ & "'"
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return "拼音读取城市出错"
        End If
        If tb.Rows.Count > 0 Then
            Return tb.Rows(0)("mc").ToString
        Else
            Return ""
        End If
    End Function
    '
    ''' <summary>
    ''' 添加区县
    ''' </summary>
    ''' <param name="mc">名称</param>
    ''' <param name="citybh">城市编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_cityqx(ByVal mc As String, ByVal citybh As Integer) As String

        If mc = "" Then
            Return "城市区县不能为空"
        End If
        If mc.Length > 20 Or mc.Length < 1 Then
            Return "城市区县名称格式不正确，字符为1-20位"
        End If
        If ym.aqjc(mc) <> "" Then
            Return "城市区县名称不支持特殊字符" & ym.aqjc(mc)
        End If
        If IsNumeric(citybh) = False Then
            Return "城市编号不正确"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into county_b (qxmc,citybh) values('" & mc & "'," & citybh & ")"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "新增城市区县出错，请联系程序员"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取城市下面的区县
    ''' </summary>
    ''' <param name="citybh">城市编号</param>
    ''' <returns>操作完成后返回表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_cityqx(ByVal citybh As Integer) As DataTable
        If IsNumeric(citybh) = False Then
            erro = "城市编号不正确"
            Return Nothing
        End If
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select * from county_b where citybh=" & citybh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 读取区县(编号读取)
    ''' </summary>
    ''' <param name="bh">区县编号</param>
    ''' <returns>操作成功后返回表，失败返回Nothing</returns>
    ''' <remarks></remarks>
    Public Function dq_cityqx(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from county_bh where bh=" & bh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 编辑区县
    ''' </summary>
    ''' <param name="bh">区县编号</param>
    ''' <param name="mc">区县名称</param>
    ''' <param name="citybh">城市编号</param>
    ''' <returns>操作成功返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_cityqx(ByVal bh As Integer, ByVal mc As String, ByVal citybh As Integer) As String
        If IsNumeric(bh) = False Then
            Return "区县编号必须是数字"
        End If
        If mc = "" Then
            Return "区县不能为空"
        End If
        If mc.Length > 20 Or mc.Length < 1 Then
            Return "城市区县名称格式不正确，字符为1-20位"
        End If
        If ym.aqjc(mc) <> "" Then
            Return "城市区县名称不支持特殊字符" & ym.aqjc(mc)
        End If
        Dim db As New mysjk("Systemk")
        Dim zx As Integer = db.zx1("update county_b set qxmc='" & mc & "',citybh=" & citybh & " where bh=" & bh)
        If zx < 0 Then
            Return "修改城市区县出错,请联系程序员"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 删除城市区县
    ''' </summary>
    ''' <param name="bh">区县编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_cityqx(ByVal bh As Integer) As String
        Dim db As New mysjk("Systemk")
        Dim tb As DataTable = Nothing
        Dim str As String
        str = "select top 1 * from trading_Area where county_bh=" & bh
        tb = db.dqb(str)
        If db.exerr <> "" Then
            erro = db.exerr
            Return "读取区县下的商圈出错"
        End If

        If tb.Rows.Count > 0 Then
            If db.zx1("delete from trading_Area where county_bh=" & bh) < 0 Then
                Return "删除城市区县下的商圈出错"
            End If
        End If
        If db.zx1("delete from county_b where bh=" & bh) < 0 Then

            Return "删除城市区县出错"
        End If
        Return ""
    End Function
    '商圈
    '添加商圈
    ''' <summary>
    ''' 增加商圈
    ''' </summary>
    ''' <param name="countybh">城市编号</param>
    ''' <param name="mc">区县名称</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_trading_area(ByVal countybh As Integer, ByVal mc As String) As String
        If IsNumeric(countybh) = False Then
            Return "请选择区县编号"
        End If
        If mc = "" Then
            Return "请传入商圈名称"
        End If
        If mc.Length > 20 Then
            Return "传入商圈名称字符长度违规"
        End If
        Dim jcmc As String = ym.aqjc(mc)
        If jcmc <> "" Then
            Return "商圈名称中不能有特殊字符"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into trading_Area (mc,county_bh) values('" & mc & "'," & countybh & ")"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "新增城市区县出错，请联系程序员"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改商圈
    ''' </summary>
    ''' <param name="bh">商圈编号</param>
    ''' <param name="countybh">区县编号</param>
    ''' <param name="mc">商圈名称</param>
    ''' <returns>操作成功后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_trading_area(ByVal bh As Integer, ByVal countybh As Integer, ByVal mc As String) As String
        If IsNumeric(bh) = False Then
            Return "传入的编号必须是数字"
        End If
        If IsNumeric(countybh) = False Then
            Return "传入的曲线编号必须是数字"
        End If
        If mc = "" Then
            Return "请传入商圈名称"
        End If
        If mc.Length > 20 Then
            Return "传入商圈名称字符长度违规"
        End If
        Dim jcmc As String = ym.aqjc(mc)
        If jcmc <> "" Then
            Return "商圈名称中不能有特殊字符"
        End If
        Dim db As New mysjk("Systemk")
        Dim zx As Integer = db.zx1("update trading_Area set mc='" & mc & "',county_bh=" & countybh & " where bh=" & bh)
        If zx < 0 Then
            Return "修改城市商圈出错,请联系程序员"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取商圈
    ''' </summary>
    ''' <param name="bh">商圈编号</param>
    ''' <returns>操作完成后返回表，失败返回Nothing</returns>
    ''' <remarks></remarks>
    Public Function read_trading_area(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from trading_Area where bh=" & bh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 删除商圈
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_trading_area(ByVal bh As Integer) As String
        Dim db As New mysjk("Systemk")
        If db.zx1("delete from county_b where bh=" & bh) < 0 Then
            Return "删除城市区县出错"
        End If
        Return ""
    End Function

#End Region
#Region "收货地址"
    '
    ''' <summary>
    ''' 增加收货地址
    ''' </summary>
    ''' <param name="userbh">用户编号</param>
    ''' <param name="xm">姓名</param>
    ''' <param name="dh">电话</param>
    ''' <param name="dz">地址</param>
    ''' <param name="zt">状态</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_receiving_address_list(ByVal userbh As Integer, ByVal xm As String, ByVal dh As String, ByVal dz As String, ByVal zt As String) As String
        If IsNumeric(userbh) = False Then
            Return "用户编号传值违规"
        End If
        If xm = "" Then
            Return "请传入收货人姓名"
        End If
        If xm.Length > 10 Then
            Return "传入的收货人姓名字符长度不能超过10个"
        End If
        Dim jcxm As String = ym.aqjc(xm)
        If jcxm <> "" Then
            Return "传入的姓名字符中不能有特殊字符" & jcxm
        End If
        If dh = "" Then
            Return "请传入收货人手机号码"
        End If
        If dh.Length > 15 Then
            Return "电话字符长度不能超过15个字符"
        End If
        Dim jcdh As String = ym.aqjc(dh)
        If jcdh <> "" Then
            Return "传入的联系方式中不能有特殊字符" & jcdh
        End If
        If dz = "" Then
            Return "请传入收货人地址"
        End If
        If dz.Length > 200 Then
            Return "联系地址的字符长度不能超过200"
        End If
        Dim jcdz As String = ym.aqjc(dz)
        If jcdz <> "" Then
            Return "传入的收货人地址中不能有特殊字符" & jcdz
        End If
        Dim str As String = ""
        If zt = 1 Then
            Dim jctb As DataTable = read_receive_address_list(userbh)
            If jctb Is Nothing Then
                Return "读取收货地址出错，请联系程序员"
            End If
            If jctb.Rows.Count > 0 Then
                Dim edit_default_zt As String = cancel_defualt_address(userbh)
                If edit_default_zt <> "" Then
                    Return edit_default_zt
                End If
            End If
        End If
        Dim db As New mysjk("Systemk")
        str = "insert into Receiving_address_list (user_bh,xm,dh,dz,default_zt,sj) values(" & userbh & ",'" & xm & "','" & dh & "','" & dz & "'," & zt & ",'" & Now & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "插入收货地址出错，请联系程序员"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取收货地址
    ''' </summary>
    ''' <param name="yhbh">用户编号</param>
    ''' <returns>操作完成后返回表失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_receive_address_list(ByVal yhbh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from Receiving_address_list where user_bh=" & yhbh & " order by bh desc"
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 指定默认收货地址
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <param name="zt">状态</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function Appoint_defualt_address_zt(ByVal bh As Integer, ByVal zt As Integer) As String
        Dim db As New mysjk("Systemk")
        Dim zx As Integer = db.zx1("update Receiving_address_list set default=" & zt & " where bh=" & bh)
        If zx < 0 Then
            Return "修指定默认收货地址出错，请联系程序员"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 取消默认地址
    ''' </summary>
    ''' <param name="userbh">用户编号</param>
    ''' <returns>操作成功后返回空值</returns>
    ''' <remarks></remarks>
    Public Function cancel_defualt_address(ByVal userbh As Integer) As String
        Dim db As New mysjk("Systemk")
        Dim zx As Integer = db.zx1("update Receiving_address_list set default=0 where user_bh=" & userbh)
        If zx < 0 Then
            Return "取消定默认收货地址出错，请联系程序员"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改收货地址
    ''' </summary>
    ''' <param name="xm">姓名</param>
    ''' <param name="dh">电话</param>
    ''' <param name="dz">地址</param>
    ''' <param name="zt">状态</param>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_receiving_address_list(ByVal xm As String, ByVal dh As String, ByVal dz As String, ByVal zt As String, ByVal bh As Integer) As String
        If xm = "" Then
            Return "请传入收货人姓名"
        End If
        If xm.Length > 10 Then
            Return "传入的收货人姓名字符长度不能超过10个"
        End If
        Dim jcxm As String = ym.aqjc(xm)
        If jcxm <> "" Then
            Return "传入的姓名字符中不能有特殊字符" & jcxm
        End If
        If dh = "" Then
            Return "请传入收货人手机号码"
        End If
        If dh.Length > 15 Then
            Return "电话字符长度不能超过15个字符"
        End If
        Dim jcdh As String = ym.aqjc(dh)
        If jcdh <> "" Then
            Return "传入的联系方式中不能有特殊字符" & jcdh
        End If
        If dz = "" Then
            Return "请传入收货人地址"
        End If
        If dz.Length > 200 Then
            Return "联系地址的字符长度不能超过200"
        End If
        Dim jcdz As String = ym.aqjc(dz)
        If jcdz <> "" Then
            Return "传入的收货人地址中不能有特殊字符" & jcdz
        End If
        Dim str As String = ""
        Dim db As New mysjk("Systemk")
        Dim zx As Integer = db.zx1("update Receiving_address_list set xm='" & xm & "',dh='" & dh & "',dz='" & dz & "',default_zt=" & zt & " where bh=" & bh)
        If zx < 0 Then
            Return "修改收货地址出错，请联系程序员"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 删除收货地址
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <returns>操作成功后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_receiving_address(ByVal bh As Integer) As String
        Dim db As New mysjk("Systemk")
        If db.zx1("delete from Receiging_address_list where bh=" & bh) < 0 Then
            Return "删除收货地址出错"
        End If
        Return ""
    End Function
#End Region
#Region "提现请求"
    '
    ''' <summary>
    ''' 创建提现请求
    ''' </summary>
    ''' <param name="userbh">用户编号</param>
    ''' <param name="je">提现金额</param>
    ''' <param name="accountnumber">收款账号</param>
    ''' <param name="banktype">收款银行</param>
    ''' <param name="zt">状态</param>
    ''' <returns>操作成功后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_widthdrawals_needs(ByVal userbh As Integer, ByVal je As Single, ByVal accountnumber As String, ByVal banktype As String, ByVal zt As Integer) As String
        If IsNumeric(userbh) = False Then
            Return "传入的用户编号出错，请联系客服"
        End If
        If ym.testfloat(je) = False Then
            Return "提现金额不符合规则"
        End If
        If accountnumber = "" Then
            Return "请填写收款账号"
        End If
        If accountnumber.Length > 30 Then
            Return "收款账号字符长度违规"
        End If
        Dim jcaccountnumber As String = ym.aqjc(accountnumber)
        If jcaccountnumber <> "" Then
            Return "收款账号中不能有特殊字符" & jcaccountnumber
        End If
        If banktype = "" Then
            Return "请填写收款账号所属银行"
        End If
        If banktype.Length > 20 Then
            Return "传入的收款账号所属银行字符长度违规"
        End If
        Dim jcbanktype As String = ym.aqjc(banktype)
        If jcbanktype <> "" Then
            Return "收款账号所属银行中不能有特殊字符" & jcbanktype
        End If
        Dim str As String = ""
        Dim db As New mysjk("Systemk")
        str = "insert into Withdrawals_need (user_bh,je,account_number,bank_type,zt,sj) values(" & userbh & ",'" & je & "','" & accountnumber & "','" & banktype & "'," & zt & ",'" & Now & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "创建提现请求出错，请联系客服人员"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取提现请求-编号
    ''' </summary>
    ''' <param name="bh">提款请求库编号</param>
    ''' <returns>操作完成后返回表，失败返回空值</returns>
    ''' <remarks></remarks>
    Public Function read_widhtdrawals(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from Widhdrawals_need where bh=" & bh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 处理请求
    ''' </summary>
    ''' <param name="zt_">状态</param>
    ''' <param name="operator_">操作人</param>
    ''' <param name="bh">编号</param>
    ''' <param name="bz">备注</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function handle_widthdrawals(ByVal zt_ As Integer, ByVal operator_ As String, ByVal bh As Integer, ByVal bz As String) As String
        If IsNumeric(zt_) = False Then
            Return "传入的请求状态修改出错"
        End If
        If IsNumeric(bh) = False Then
            Return "传入的编号违规"
        End If
        If operator_ = "" Then
            Return "请求处理人姓名不能为空"
        End If
        If operator_.Length > 5 Then
            Return "请求处理人姓名字符长度不能超过5位"
        End If
        Dim jcoperator As String = ym.aqjc(operator_)
        If jcoperator <> "" Then
            Return "处理请求的人姓名中不能有特殊字符" & jcoperator
        End If
        If bz <> "" Then
            If bz.Length > 100 Then
                Return "备注中的字符最多为100字符"
            End If
            Dim jcbz As String = ym.aqjc(bz)
            If jcbz <> "" Then
                Return "备注不支持特殊字符" & jcbz
            End If
        End If
        Dim str As String = ""
        Dim db As New mysjk("Systemk")
        Dim zx As Integer = db.zx1("update Withdrawals_need set operator='" & operator_ & "',zt=" & zt_ & ",bz='" & bz & "',operator_sj='" & Now & "' where bh=" & bh)
        If zx < 0 Then
            Return "处理提现请求出错，请联系程序员"
        End If
        Return ""
    End Function
#End Region
#Region "账目明细"
    '
    ''' <summary>
    ''' 增加明细
    ''' </summary>
    ''' <param name="user_bh">用户编号</param>
    ''' <param name="type_">记录类型</param>
    ''' <param name="je">消费金额</param>
    ''' <param name="nowye">当前余额</param>
    ''' <param name="mc">名称</param>
    ''' <param name="object_">交易对象</param>
    ''' <param name="serial_number">流水号【18位字符】</param>
    ''' <param name="integral">小号积分</param>
    ''' <param name="now_intrgral">当下剩余积分</param>
    ''' <returns>操作成功后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_account_details_list(ByVal user_bh As Integer, ByVal type_ As Integer, ByVal je As Single, ByVal nowye As Single, ByVal mc As String, ByVal object_ As String, ByVal serial_number As String, ByVal integral As Integer, ByVal now_intrgral As Integer) As String
        If IsNumeric(user_bh) = False Then
            Return "传入的用户编号必须是数字"
        End If
        If IsNumeric(type_) = False Then
            Return "充值方式传入的值不符合规则"
        End If
        If ym.testfloat(je) = False Then
            Return "传入的金额不符合规则"
        End If
        If ym.testfloat(nowye) = False Then
            Return "传入的当下金额不符合规则"
        End If
        If object_ = "" Then
            Return "传入的对象名称不能为空"
        End If
        If mc = "" Then
            Return "请传入名称"
        End If
        If mc.Length > 20 Then
            Return "当前交易的名称字符长度不能超过20个"
        End If
        If object_.Length > 50 Then
            Return "传入的对象字符长度不能超过50个字符"
        End If
        serial_number = ym.create_number() '保存流水号
        If IsNumeric(integral) = False Then
            Return "消耗的积分必须是数字"
        End If
        If IsNumeric(now_intrgral) = False Then
            Return "当下剩余的积分必须是数字"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into Account_details_list (user_bh,type_,je,now_ye,mc,object_,serial_number,integral,now_integral,sj) "
        str &= "values(" & user_bh & "," & type_ & ",'" & je & "','" & nowye & "','" & mc & "','" & object_ & "','" & serial_number & "'," & integral & "," & now_intrgral & ",'" & Now & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "写入账目系统失败，请联系程序员调试"
        End If
        Return ""
    End Function

#End Region
#Region "退款请求"
    '
    ''' <summary>
    ''' 创建退款请求
    ''' </summary>
    ''' <param name="userbh">用户编号</param>
    ''' <param name="orderbh">订单编号</param>
    ''' <param name="zt">状态</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_refund_nnd_list(ByVal userbh As Integer, ByVal orderbh As Integer, ByVal zt As Integer) As String
        If IsNumeric(userbh) = False Then
            Return "用户编号必须是数字"
        End If
        If IsNumeric(orderbh) = False Then
            Return "退款的订单编号传值违规"
        End If
        If IsNumeric(zt) = False Then
            Return "退款状态传值必须是数字"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into refund_need_list (user_bh,order_bh,sj,zt) "
        str &= "values(" & userbh & "," & orderbh & ",'" & Now & "',2)"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "写入退款请求系统失败，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 处理退款请求
    ''' </summary>
    ''' <param name="bh">退款编号</param>
    ''' <param name="operator_">处理人姓名</param>
    ''' <param name="zt_">状态</param>
    ''' <param name="bz">备注内容</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function handle_refund_need(ByVal bh As Integer, ByVal operator_ As String, ByVal zt_ As Integer, ByVal bz As String) As String
        If operator_ = "" Then
            Return "请传入处理此条退款请求的人员名字"
        End If
        If operator_.Length > 5 Then
            Return "处理此条退款请求的人员名字长度不能超过5位字符"
        End If
        If bz <> "" Then
            Dim jcbz As String = ym.aqjc(bz)
            If jcbz <> "" Then
                Return "处理退款备注内容中不能有特殊字符" & jcbz
            End If
        End If
        Dim str As String = ""
        Dim db As New mysjk("Systemk")
        Dim zx As Integer = db.zx1("update refund_need_list set operator='" & operator_ & "',zt=" & zt_ & ",bz='" & bz & "',operator_sj='" & Now & "' where bh=" & bh)
        If zx < 0 Then
            Return "处理退款请求出错，请联系程序员"
        End If
        Return ""
    End Function

#End Region
    '————————————————————网站管理员——————————————————————————
#Region "管理员"
    '
    ''' <summary>
    ''' 增加管理员
    ''' </summary>
    ''' <param name="yhm">用户名</param>
    ''' <param name="mm">密码</param>
    ''' <param name="qx">权限</param>
    ''' <param name="xm">姓名</param>
    ''' <param name="zw">职位</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_admin_user(ByVal yhm As String, ByVal mm As String, ByVal qx As Integer, ByVal xm As String, ByVal zw As String) As String
        If yhm = "" Then
            Return "用户名不能是空"
        End If
        If yhm.Length > 15 Or yhm.Length < 8 Then
            Return "传入的用户名不符合规则"
        End If
        Dim jcyhm As String = ym.aqjc(yhm)
        If jcyhm <> "" Then
            Return "用户名中不能有特殊字符" & jcyhm
        End If
        If mm = "" Then
            Return "密码不能为空"
        End If
        If mm.Length > 15 Or mm.Length < 5 Then
            Return "密码支付长度不符合规则"
        End If
        Dim jcmm As String = ym.aqjc(mm)
        If jcmm <> "" Then
            Return "密码字符中不能有特殊字符" & jcmm
        End If
        If IsNumeric(qx) = False Then
            Return "权限传值不正确"
        End If
        If xm = "" Then
            Return "姓名不能为空"
        End If
        If xm.Length > 5 Then
            Return "传入的姓名字符长度违规"
        End If
        Dim jcxm As String = ym.aqjc(xm)
        If jcxm <> "" Then
            Return "姓名中不能有特殊字符" & jcxm
        End If
        If zw = "" Then
            Return "职务不能为空"
        End If
        If zw.Length > 20 Then
            Return "职务字符长度不能超过20个字符"
        End If
        Dim jczw As String = ym.aqjc(zw)
        If jczw <> "" Then
            Return "职务中不能有特殊字符" & jczw
        End If

        Dim db As New mysjk("Systemk")
        Dim md5mm As String = md5jm.Encrypt(yhm & mm, 32) 'md5加盐
        Dim str As String = "insert into admink (yhm,mm,qx,xm,zw,sj) values('" & yhm & "','" & md5mm & "'," & qx & ",'" & xm & "','" & zw & "','" & Now & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "用户名注册出错，请联系技术部"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改资料
    ''' </summary>
    ''' <param name="yhm">用户名</param>
    ''' <param name="mm">密码</param>
    ''' <param name="qx">权限</param>
    ''' <param name="xm">姓名</param>
    ''' <param name="zw">职位</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_admin_user(ByVal yhm As String, ByVal mm As String, ByVal qx As String, ByVal xm As String, ByVal zw As String) As String
        If yhm = "" Then
            Return "用户名不能是空"
        End If
        If yhm.Length > 15 Or yhm.Length < 8 Then
            Return "传入的用户名不符合规则"
        End If
        Dim jcyhm As String = ym.aqjc(yhm)
        If jcyhm <> "" Then
            Return "用户名中不能有特殊字符" & jcyhm
        End If
        If mm = "" Then
            Return "密码不能为空"
        End If
        If mm.Length > 15 Or mm.Length < 5 Then
            Return "密码支付长度不符合规则"
        End If
        Dim jcmm As String = ym.aqjc(mm)
        If jcmm <> "" Then
            Return "密码字符中不能有特殊字符" & jcmm
        End If
        If IsNumeric(qx) = False Then
            Return "权限传值不正确"
        End If
        If xm = "" Then
            Return "姓名不能为空"
        End If
        If xm.Length > 5 Then
            Return "传入的姓名字符长度违规"
        End If
        Dim jcxm As String = ym.aqjc(xm)
        If jcxm <> "" Then
            Return "姓名中不能有特殊字符" & jcxm
        End If
        If zw = "" Then
            Return "职务不能为空"
        End If
        If zw.Length > 20 Then
            Return "职务字符长度不能超过20个字符"
        End If
        Dim jczw As String = ym.aqjc(zw)
        If jczw <> "" Then
            Return "职务中不能有特殊字符" & jczw
        End If

        Dim db As New mysjk("Systemk")
        Dim md5mm As String = md5jm.Encrypt(yhm & mm, 32) 'md5加盐
        Dim zx As Integer = db.zx1("update reg_table set mm='" & md5mm & "',qx=" & qx & ",xm='" & xm & "',zw='" & zw & "' where yhm='" & yhm & "'")
        If db.exerr <> "" Then
            Return "修改密码出错，请重试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改密码
    ''' </summary>
    ''' <param name="yhm">用户名</param>
    ''' <param name="o_mm">原密码</param>
    ''' <param name="n_mm">新密码</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_admin_mm(ByVal yhm As String, ByVal o_mm As String, ByVal n_mm As String) As String
        If yhm = "" Then
            Return "用户名不能为空"
        End If
        If ym.aqjc(yhm) <> "" Then
            Return "用户名不支持特殊字符" & ym.aqjc(yhm)
        End If
        If o_mm = "" Then
            Return "原密码不能为空"
        End If
        If o_mm.Length > 15 Or o_mm.Length < 5 Then
            Return "原密码格式不正确，是5-15位字符"
        End If
        If ym.aqjc(o_mm) <> "" Then
            Return "原密码不支持特殊字符 " & ym.aqjc(o_mm)
        End If
        If n_mm = "" Then
            Return "新密码不能为空"
        End If
        If ym.aqjc(n_mm) <> "" Then
            Return "新密码不支持特殊字符 " & ym.aqjc(o_mm)
        End If
        If n_mm.Length > 15 Or n_mm.Length < 5 Then
            Return "新密码格式不正确，是5-15位字符"
        End If
        Dim tb As DataTable = Nothing
        Dim db As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from admink where yhm='" & yhm & "'"
        tb = db.dqb(str)
        If db.exerr <> "" Then
            erro = db.exerr
            Return erro
        End If
        Dim n_md5 As String = md5jm.Encrypt(yhm & n_mm, 32)
        Dim zx As Integer = db.zx1("update admink set mm='" & n_md5 & "' where yhm='" & yhm & "'")
        If db.exerr <> "" Then
            Return "修改密码出错，请重试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取单个用户资料
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_admin_user(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from admink where bh=" & bh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 删除个人用户
    ''' </summary>
    ''' <param name="bh">用户编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_admin_user(ByVal bh As Integer) As String
        Dim db As New mysjk("Systemk")
        Dim str As String = "delete from admink where bh=" & bh
        If db.zx1(str) < 0 Then
            Return "无法完成删除此管理员的操作，请联系网站管理员。"
        End If
        Return ""
    End Function
#End Region
#Region "商品单位"
    '
    ''' <summary>
    ''' 单位增加
    ''' </summary>
    ''' <param name="mc">单位名称</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function add_unit(ByVal mc As String) As String
        If mc = "" Then
            Return "单位名称不能为空"
        End If
        If mc.Length > 5 Then
            Return "单位名称字符长度最多5位"
        End If
        Dim jcmc As String = ym.aqjc(mc)
        If jcmc <> "" Then
            Return "单位字符名称中不能有特殊字符" & jcmc
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into unit_list (mc) "
        str &= "values('" & mc & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "增加单位名称出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改单位
    ''' </summary>
    ''' <param name="mc">名称</param>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_unit(ByVal mc As String, ByVal bh As Integer) As String
        If IsNumeric(bh) = False Then
            Return "传入的编号必须是数字"
        End If
        If mc = "" Then
            Return "单位名称不能为空"
        End If
        If mc.Length > 5 Then
            Return "单位名称字符长度最多5位"
        End If
        Dim jcmc As String = ym.aqjc(mc)
        If jcmc <> "" Then
            Return "单位字符名称中不能有特殊字符" & jcmc
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update bank_list set mc='" & mc & "' where bh=" & bh
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改单位名称出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '删除单位
    ''' <summary>
    ''' 删除单位
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_unit(ByVal bh As Integer) As String
        Dim db As New mysjk("Systemk")
        Dim str As String = "delete from unit_list where bh=" & bh
        If db.zx1(str) < 0 Then
            'erro = "无法完成删除此单位的操作，请联系网站管理员。"
            Return "无法完成删除此单位的操作，请联系网站管理员。"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取单位
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_unit(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        If bh = 0 Then
            str = "select * from unit_list"
        Else
            str = "select top 1 * from unit_list where bh=" & bh
        End If
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
#End Region
#Region "公司内页类目"
    '
    ''' <summary>
    ''' 增加公司内页类目
    ''' </summary>
    ''' <param name="mc">名称</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_company_class(ByVal mc As String) As String
        If mc = "" Then
            Return "内页类目名称不能为空"
        End If
        If mc.Length > 50 Then
            Return "内页类目名称字符长度最多50位"
        End If
        Dim jcmc As String = ym.aqjc(mc)
        If jcmc <> "" Then
            Return "内页类目名称中不能有特殊字符" & jcmc
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into company_class (mc) "
        str &= "values('" & mc & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "增加内页类目名称出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改类目名称
    ''' </summary>
    ''' <param name="mc">类目名称</param>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_company_class(ByVal mc As String, ByVal bh As Integer) As String
        If IsNumeric(bh) = False Then
            Return "传入的单位必须是数字"
        End If
        If mc = "" Then
            Return "内页类目名称不能为空"
        End If
        If mc.Length > 50 Then
            Return "内页类目名称字符长度最多50位"
        End If
        Dim jcmc As String = ym.aqjc(mc)
        If jcmc <> "" Then
            Return "内页类目名称中不能有特殊字符" & jcmc
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update company_class set mc='" & mc & "' where bh=" & bh
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改公司内页类目名称出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 删除公司内页类目
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_company_calss(ByVal bh As String) As String
        If IsNumeric(bh) = False Then
            Return "公司内页编号必须是数字"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = ""
        str = "select * from company_class_content where class_bh=" & bh
        Dim tb As DataTable = db.dqb(str)
        If db.exerr <> "" Then
            erro = db.exerr
            Return erro
        End If
        If tb.Rows.Count > 0 Then
            str = "delete from company_class_content where class_bh=" & bh
            If db.zx1(str) < 0 Then
                Return "无法完成删除内页分类下的内页，请联系程序员。"
            End If
        End If
        str = "delete from company_class where bh=" & bh
        If db.zx1(str) < 0 Then
            Return "无法完成删除此单位的操作，请联系网站管理员。"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取内页类目
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_company_class(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        If bh = 0 Then
            str = "select * from company_class"
        Else
            str = "select top 1 * from company_class where bh=" & bh
        End If
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
#End Region
#Region "公司内页"
    '
    ''' <summary>
    ''' 增加公司内页
    ''' </summary>
    ''' <param name="classbh">分类编号</param>
    ''' <param name="title_">标题</param>
    ''' <param name="content_">内容</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_compay_content(ByVal classbh As Integer, ByVal title_ As String, ByVal content_ As String) As String
        If IsNumeric(classbh) = False Then
            Return "传入的内页类目编号必须是数字"
        End If
        If title_ = "" Then
            Return "内页类目标题不能是空的"
        End If
        If title_.Length > 200 Then
            Return "内页标题字符长度不能超过200个"
        End If
        Dim jctitle As String = ym.aqjc(title_)
        If jctitle <> "" Then
            Return "内页标题字符中不能有特殊字符" & jctitle
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into company_class_content (class_bh,title,content_,sj) "
        str &= "values(" & classbh & ",'" & content_ & "','" & Now & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "增加内页出错名称出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改公司内页内容
    ''' </summary>
    ''' <param name="classbh">分类编号</param>
    ''' <param name="title_">标题</param>
    ''' <param name="bh">编号</param>
    ''' <param name="nr">内容</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_compay_content(ByVal classbh As Integer, ByVal title_ As String, ByVal bh As Integer, ByVal nr As String) As String
        If IsNumeric(classbh) = False Then
            Return "传入的内页类目编号必须是数字"
        End If
        If IsNumeric(bh) = False Then
            Return "传入的变化必须是数字"
        End If
        If title_ = "" Then
            Return "内页类目标题不能是空的"
        End If
        If title_.Length > 200 Then
            Return "内页标题字符长度不能超过200个"
        End If
        Dim jctitle As String = ym.aqjc(title_)
        If jctitle <> "" Then
            Return "内页标题字符中不能有特殊字符" & jctitle
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update company_class_content set title='" & title_ & "',content_='" & nr & "',class_bh='" & classbh & "' where bh=" & bh
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改内页内容出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取内容
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回一个表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_company_content(ByVal bh As String) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        If bh = 0 Then
            str = "select * from company_class_content"
        Else
            str = "select top 1 * from company_class_content where bh=" & bh
        End If
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    '
    ''' <summary>
    ''' 删除公司内页
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_company_content(ByVal bh As Integer) As String
        If IsNumeric(bh) = False Then
            Return "公司内页编号必须是数字"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = ""
        str = "delete from company_class_content where bh=" & bh
        If db.zx1(str) < 0 Then
            Return "无法完成删除内页分类下的内页，请联系程序员。"
        End If
        Return ""
    End Function
#End Region
#Region "新闻类目"
    '
    ''' <summary>
    ''' 增加新闻类目
    ''' </summary>
    ''' <param name="mc">名称</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_new_class(ByVal mc As String) As String
        If mc = "" Then
            Return "新闻分类类目名称不能为空"
        End If
        If mc.Length > 50 Then
            Return "新闻分类类目名称字符长度最多50位"
        End If
        Dim jcmc As String = ym.aqjc(mc)
        If jcmc <> "" Then
            Return "新闻分类类目名称中不能有特殊字符" & jcmc
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into news_class (mc) "
        str &= "values('" & mc & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "增加新闻分类类目名称出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改新闻类目
    ''' </summary>
    ''' <param name="mc">名称</param>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_new_class(ByVal mc As String, ByVal bh As Integer) As String
        If IsNumeric(bh) = False Then
            Return "新闻类目编号传值不正确"
        End If

        If mc = "" Then
            Return "新闻分类类目名称不能为空"
        End If
        If mc.Length > 50 Then
            Return "新闻分类类目名称字符长度最多50位"
        End If
        Dim jcmc As String = ym.aqjc(mc)
        If jcmc <> "" Then
            Return "新闻分类类目名称中不能有特殊字符" & jcmc
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update news_class set mc='" & mc & "' where bh=" & bh
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改新闻分类类目名称出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 删除类目
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_new_class(ByVal bh As Integer) As String
        If IsNumeric(bh) = False Then
            Return "新闻分类类目编号必须是数字"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = ""
        str = "select * from news_class_content where news_class_bh=" & bh
        Dim tb As DataTable = db.dqb(str)
        If db.exerr <> "" Then
            erro = db.exerr
            Return erro
        End If
        If tb.Rows.Count > 0 Then
            str = "delete from news_class_content where news_class_bh=" & bh
            If db.zx1(str) < 0 Then

                Return "无法完成删除新闻分类下的内页，请联系程序员。"
            End If
        End If
        str = "delete from news_class where bh=" & bh
        If db.zx1(str) < 0 Then
            Return "无法完成删除此新闻分类的操作，请联系网站管理员。"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 读取新闻类目
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回表，失败返回nothing</returns>
    ''' <remarks></remarks>
    Public Function read_news_class(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        If bh = 0 Then
            str = "select * from news_class"
        Else
            str = "select top 1 * from news_class where bh=" & bh
        End If
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
#End Region
#Region "新闻信息"
    '
    ''' <summary>
    ''' 发布新闻消息
    ''' </summary>
    ''' <param name="classbh">类目编号</param>
    ''' <param name="nr">新闻内容</param>
    ''' <param name="title_">新闻标题</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_news_countent(ByVal classbh As Integer, ByVal nr As String, ByVal title_ As String) As String
        If IsNumeric(classbh) = False Then
            Return "新闻类目编号必须是数字"
        End If
        If title_ = "" Then
            Return "请填写新闻标题"
        End If
        If title_.Length > 40 Then
            Return "新闻标题字符长度不能超过40个字符"
        End If
        Dim jctitle As String = ym.aqjc(title_)
        If jctitle <> "" Then
            Return "新闻标题中不能有特殊字符" & jctitle
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into news_class_content (news_class_bh,title,content) "
        str &= "values(" & classbh & ",'" & nr & "','" & title_ & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "增加新闻内容出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 修改新闻内容
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <param name="title">标题</param>
    ''' <param name="classbh">分类编号</param>
    ''' <param name="nr">内容</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_news_countent(ByVal bh As String, ByVal title As String, ByVal classbh As Integer, ByVal nr As String) As String
        If IsNumeric(classbh) = False Then
            Return "新闻类目编号必须是数字"
        End If
        If title = "" Then
            Return "请填写新闻标题"
        End If
        If title.Length > 40 Then
            Return "新闻标题字符长度不能超过40个字符"
        End If
        Dim jctitle As String = ym.aqjc(title)
        If jctitle <> "" Then
            Return "新闻标题中不能有特殊字符" & jctitle
        End If
        If IsNumeric(bh) = False Then
            Return "新闻编号必须是数字"
        End If
        If IsNumeric(classbh) = False Then
            Return "新闻类目编号必须是数字"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update news_class_content set title='" & title & "',content_='" & nr & "',news_class_bh='" & classbh & "' where bh=" & bh
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改新闻出错，请联系程序员调试"
        End If
        Return ""
    End Function
    '
    ''' <summary>
    ''' 删除新闻
    ''' </summary>
    ''' <param name="bh">编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_news_countent(ByVal bh As Integer) As String
        If IsNumeric(bh) = False Then
            Return "公司内页编号必须是数字"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = ""
        str = "delete from news_class_content where bh=" & bh
        If db.zx1(str) < 0 Then
            Return "无法完成删除内页分类下的内页，请联系程序员。"
        End If
        Return ""
    End Function

#End Region
#Region "活动系统"
    ''' <summary>
    ''' 增加活动
    ''' </summary>
    ''' <param name="city">城市名称</param>
    ''' <param name="fl">活动分类，一级二级类目组合用-组合，使用数组拆分</param>
    ''' <param name="activitymoney">活动充值金额</param>
    ''' <param name="activityname">活动名称</param>
    ''' <param name="userlife">单张券使用周期</param>
    ''' <param name="usernumber">使用数量</param>
    ''' <param name="onemoney">单张金额</param>
    ''' <param name="one_integral">单张积分</param>
    ''' <param name="starsj">活动开始时间</param>
    ''' <param name="endsj">活动结束时间</param>
    ''' <param name="activitycount">活动券发行总量</param>
    ''' <param name="operationman">创建活动人姓名</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function add_activity(ByVal city As String, ByVal fl As String, ByVal activitymoney As Double, ByVal activityname As String, ByVal userlife As Integer, ByVal usernumber As Integer, ByVal onemoney As Double, ByVal one_integral As Integer, ByVal starsj As String, ByVal endsj As String, ByVal activitycount As Integer, ByVal operationman As String) As String
        If city = "" Then
            Return "请选择城市"
        End If
        If fl = "" Then
            Return "请选活动分类"
        End If
        If ym.testfloat(activitymoney) = False Then
            Return "活动金额传入违规"
        End If
        If activityname = "" Then
            Return "请填写活动"
        End If
        If activityname.Length > 100 Then
            Return "活动名称字符长度不能超过100个"
        End If
        Dim jcactivityname As String = ym.aqjc(activityname)
        If jcactivityname <> "" Then
            Return "活动名称中不能有特殊字符" & jcactivityname
        End If
        If IsNumeric(userlife) = False Then
            Return "使用周期必须是数字"
        End If
        If IsNumeric(usernumber) = False Then
            Return "优惠券数量必须是数字"
        End If
        If ym.testfloat(onemoney) = False Then
            Return "活动券的单价金额违规"
        End If
        If IsNumeric(one_integral) = False Then
            Return "活动券赠送的积分金额必须是数字"
        End If
        If starsj = "" Then
            Return "请填写活动券开始时间"
        End If
        If endsj = "" Then
            Return "请填写活动券结束时间"
        End If
        If IsNumeric(activitycount) = False Then
            Return "购物券活动数量必须输数字"
        End If
        If operationman = "" Then
            Return "请填写活动上传人姓名"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "insert into activity_list (city,fl,activity_money,activity_name,user_life,user_number,one_money,one_integral,star_sj,end_sj,activity_count,operation_man) "
        str &= "values('" & city & "','" & fl & "','" & activitymoney & "','" & activityname & "'," & userlife & "," & usernumber & ",'" & onemoney & "'," & one_integral & ",'" & starsj & "','" & endsj & "'," & activitycount & ",'" & operationman & "')"
        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "新增活动信息出错，请联系网站管理员"
        End If
        Return ""
    End Function
    ''' <summary>
    ''' 修改活动
    ''' </summary>
    ''' <param name="bh">活动编号</param>
    ''' <param name="city">城市名称</param>
    ''' <param name="fl">活动分类，一级二级类目组合用-组合，使用数组拆分</param>
    ''' <param name="activitymoney">活动充值金额</param>
    ''' <param name="activityname">活动名称</param>
    ''' <param name="userlife">单张券使用周期</param>
    ''' <param name="usernumber">使用数量</param>
    ''' <param name="onemoney">单张金额</param>
    ''' <param name="one_integral">单张积分</param>
    ''' <param name="starsj">活动开始时间</param>
    ''' <param name="endsj">活动结束时间</param>
    ''' <param name="activitycount">活动券发行总量</param>
    ''' <param name="operationman">创建活动人姓名</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function edit_activity(ByVal bh As Integer, ByVal city As String, ByVal fl As String, ByVal activitymoney As Double, ByVal activityname As String, ByVal userlife As Integer, ByVal usernumber As Integer, ByVal onemoney As Double, ByVal one_integral As Integer, ByVal starsj As String, ByVal endsj As String, ByVal activitycount As Integer, ByVal operationman As String) As String
        If IsNumeric(bh) = False Then
            Return "活动编号必须是数字"
        End If
        If city = "" Then
            Return "请选择城市"
        End If
        If fl = "" Then
            Return "请选活动分类"
        End If
        If ym.testfloat(activitymoney) = False Then
            Return "活动金额传入违规"
        End If
        If activityname = "" Then
            Return "请填写活动"
        End If
        If activityname.Length > 100 Then
            Return "活动名称字符长度不能超过100个"
        End If
        Dim jcactivityname As String = ym.aqjc(activityname)
        If jcactivityname <> "" Then
            Return "活动名称中不能有特殊字符" & jcactivityname
        End If
        If IsNumeric(userlife) = False Then
            Return "使用周期必须是数字"
        End If
        If IsNumeric(usernumber) = False Then
            Return "优惠券数量必须是数字"
        End If
        If ym.testfloat(onemoney) = False Then
            Return "活动券的单价金额违规"
        End If
        If IsNumeric(one_integral) = False Then
            Return "活动券赠送的积分金额必须是数字"
        End If
        If starsj = "" Then
            Return "请填写活动券开始时间"
        End If
        If endsj = "" Then
            Return "请填写活动券结束时间"
        End If
        If IsNumeric(activitycount) = False Then
            Return "购物券活动数量必须输数字"
        End If
        If operationman = "" Then
            Return "请填写活动上传人姓名"
        End If
        Dim db As New mysjk("Systemk")
        Dim str As String = "update activity_list set city='" & city & "',fl='" & fl & "',activity_money='" & activitymoney & "',activity_name='" & activityname & "',user_life=" & userlife & ",user_number=" & usernumber & ",one_money='" & onemoney & "',one_integral=" & one_integral & ",star_sj='" & starsj & "',end_sj='" & endsj & "',activity_count=" & activitycount & ",operation_man='" & operationman & "' where bh=" & bh

        Dim zx As Integer = db.zx1(str)
        If zx < 0 Then
            Return "修改活动信息出错，请联系网站管理员"
        End If
        Return ""
    End Function
    ''' <summary>
    ''' 编号读取分类
    ''' </summary>
    ''' <param name="bh">活动编号</param>
    ''' <returns>单挑活动的表</returns>
    ''' <remarks>操作完成后返回表，失败返回nothing</remarks>
    Public Function dq_activity(ByVal bh As Integer) As DataTable
        Dim tb As DataTable = Nothing
        Dim db1 As New mysjk("Systemk")
        Dim str As String = ""
        str = "select top 1 * from activity_list where bh=" & bh
        tb = db1.dqb(str)
        If db1.exerr <> "" Then
            erro = db1.exerr
            Return Nothing
        End If
        Return tb
    End Function
    ''' <summary>
    ''' 删除活动
    ''' </summary>
    ''' <param name="bh">活动编号</param>
    ''' <returns>操作完成后返回空值</returns>
    ''' <remarks></remarks>
    Public Function del_activity(ByVal bh As Integer) As String
        Dim db As New mysjk("Systemk")
        If db.zx1("delete from activity_list where bh=" & bh) < 0 Then
            Return "删除活动出错，请联系技术部"
        End If
        Return ""
    End Function
#End Region
    '—————————————————————保险——————————————————————————————
End Class
