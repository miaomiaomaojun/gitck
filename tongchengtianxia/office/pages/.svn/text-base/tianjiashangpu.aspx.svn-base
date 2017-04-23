<%@ Page Language="VB" AutoEventWireup="false" CodeFile="tianjiashangpu.aspx.vb" Inherits="office_pages_tianjiashangpu" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>添加商铺</title>
    <meta name="renderer" content="webkit">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <meta name="apple-mobile-web-app-status-bar-style" content="black">
    <meta name="apple-mobile-web-app-capable" content="yes">
    <meta name="format-detection" content="telephone=no">
    <link rel="shortcut icon" href="/office/images/favicon.ico" />
    <link rel="stylesheet" href="/office/plugins/layui/css/layui.css" media="all" />
    <link rel="stylesheet" href="/office/css/global.css" media="all">
    <link rel="stylesheet" href="/office/plugins/font-awesome/css/font-awesome.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="layui-layout layui-layout-admin" style="border-bottom: solid 5px #00c1de;">
            <uc1:top runat="server" ID="top" />
            <uc1:left_link runat="server" ID="left_link" />
            <div class="layui-body" style="bottom: 0; border-left: solid 2px #00c1de;" id="admin-body">
                <div class="layui-tab admin-nav-card layui-tab-brief" lay-filter="admin-tab">
                    <ul class="layui-tab-title">
                        <li class="layui-this">
                            <i class="fa fa-dashboard" aria-hidden="true"></i>
                            <cite>添加商铺</cite>
                        </li>
                    </ul>
                    <div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0; background: #fff;">
                        <div class="layui-tab-item layui-show">
                            <!--内容-->
                            <div id="nav_name" name="添加商铺">
                                <div style="padding: 15px;">
                                    <div class="layui-form">
                                        <!--数字-->
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">用户库编号</label>
                                            <div class="layui-input-inline">
                                                <input type="number" name="user_bh" lay-verify="number" autocomplete="off" class="layui-input" value="123">
                                            </div>
                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">用户名</label>
                                            <div class="layui-input-inline">
                                                <input type="text" name="username" lay-verify="phone" autocomplete="off" class="layui-input" value="15751000000">
                                            </div>
                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">店铺所在城市</label>
                                            <div class="layui-input-inline">
                                                <select name="city" lay-filter="city" lay-verify="required">
                                                    <option value="">城市</option>
                                                    <option value="1" selected="selected">徐州</option>
                                                    <option value="2">上海</option>
                                                    <option value="3">南京</option>
                                                </select>
                                            </div>
                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">店铺联系人</label>
                                            <div class="layui-input-inline">
                                                <input type="text" name="name" lay-verify="renming" autocomplete="off" class="layui-input" value="李孝利">
                                            </div>
                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">店铺联系电话</label>
                                            <div class="layui-input-inline">
                                                <input type="tel" name="phone" lay-verify="phone" autocomplete="off" class="layui-input" value="15751000000">
                                            </div>
                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">店铺地址</label>
                                            <div class="layui-input-block">
                                                <input type="text" name="dress" lay-verify="required" autocomplete="off" class="layui-input" value="徐州市泉山区黄河北路90号">
                                            </div>
                                        </div>
 
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">收款方式</label>
                                            <div class="layui-input-inline">
                                                <select name="shoukuanfangshi" lay-filter="shoukuanfangshi" lay-verify="required">
                                                    <option value="">请选择方式</option>
                                                    <option value="1">银行卡</option>
                                                    <option value="2" selected="selected">支付宝</option>
                                                    <option value="3">微信</option>
                                                </select>
                                            </div>
                                            <label class="layui-form-label">收款账号</label>
                                            <div class="layui-input-inline">
                                                <input type="text" name="zhanghao" lay-verify="required" autocomplete="off" class="layui-input" value="15751000000">
                                            </div>
                                            <label class="layui-form-label">收款人</label>
                                            <div class="layui-input-inline">
                                                <input type="text" name="shoukuanname" lay-verify="renming" autocomplete="off" class="layui-input" value="李孝利">
                                            </div>
                                            
                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">一级类目</label>
                                            <div class="layui-input-inline">
                                                <select name="firstclass" lay-filter="firstclass" lay-verify="required">
                                                    <option value="">一级类目</option>
                                                    <option value="1" selected="selected">美食</option>
                                                    <option value="2">旅游</option>
                                                    <option value="3">美容</option>
                                                </select>
                                            </div>
                                            <label class="layui-form-label">二级类目</label>
                                            <div class="layui-input-inline">
                                                <select name="secondclass" lay-filter="secondclass" lay-verify="required">
                                                    <option value="">二级类目</option>
                                                    <option value="1">烧烤</option>
                                                    <option value="2" selected="selected">西餐</option>
                                                    <option value="3">自助餐</option>
                                                </select>
                                            </div>
                                        </div>
										<div class="layui-form-item">
                                            <label class="layui-form-label">店铺类型</label>
                                            <div class="layui-input-inline">
                                                <select name="leixing" lay-filter="leixing" lay-verify="required">
                                                    <option value="0">不限</option>
                                                    <option value="1" selected="selected">团购</option>
                                                    <option value="2">外卖</option>
                                                </select>
                                            </div>
                                        </div>
                                       <div class="layui-form-item">
                                            <label class="layui-form-label">描述</label>
                                            <div class="layui-input-block">
                                                <textarea id="miaoshu" style="width:100%;height: 150px;" name="miaoshu">我的食材最新鲜，我的食材最新鲜，我的食材最新鲜，我的食材最新鲜，</textarea>
                                            </div>
                                        </div>
                                       
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">头部图片</label>
                                            <div class="layui-input-inline">
                                                <input type="file" name="file1" accept="image/gif,image/jpg,image/jpeg,image/bmp,image/png" autocomplete="off" class="layui-input" style="line-height: 30px;">
                                                
                                            </div>
                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">二维码图片</label>
                                            <div class="layui-input-inline">
                                                <input type="file" name="file2" accept="image/gif,image/jpg,image/jpeg,image/bmp,image/png" autocomplete="off" class="layui-input" style="line-height: 30px;">
                                            </div>
                                        </div>
                                        
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">店铺名称</label>
                                            <div class="layui-input-inline">
                                                <input type="text" name="dianpuname" lay-verify="feikongbai" autocomplete="off" class="layui-input" value="李孝利牛排">
                                            </div>
                                        </div>
                                      
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">商圈</label>
                                            <div class="layui-input-inline">
                                                <select name="shangquan" lay-filter="shangquan" lay-verify="required">
                                                    <option value="">商圈</option>
                                                    <option value="1" selected="selected">万达广场</option>
                                                    <option value="2">段庄广场</option>
                                                </select>
                                            </div>
                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label"></label>
                                            <div class="layui-input-block">
                                                <button class="layui-btn" lay-submit="" lay-filter="demo1">立即提交</button>
                                                <button type="button" class="layui-btn layui-btn-primary" id="back">返回</button>
                                            </div>
                                        </div>

                                    </div>
                                	
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <uc1:bottom runat="server" ID="bottom" />

        </div>
        <script type="text/javascript" src="/office/plugins/layui/layui.js"></script>
        <script type="text/javascript" src="/office/js/index.js"></script>
        <script>
            layui.config({
                base: '/office/js/'
            });
            layui.use(['form', 'laypage', 'layer', 'laydate', 'layedit'], function () {
                var laypage = layui.laypage,
					$ = layui.jquery,
					layer = layui.layer, //获取当前窗口的layer对象
					layerTips = parent.layer === undefined ? layui.layer : parent.layer, //获取父窗口的layer对象
					form = layui.form();
                var layedit = layui.layedit;


                $("#back").click(function () {
                    history.go(-1);
                })

                //添加nav选中项
                var str = $("#nav_name").attr("name");
                $("dd[title=" + str + "]").addClass("layui-this").parents("li").addClass("layui-nav-itemed");

                //验证
                form.verify({
                    renming: [/^[\u4e00-\u9fa5]{2,}$/, '请输入完整的中文姓名'],
                    feikongbai: [/^\S{1,50}$/, '请输入1到50个非空白字符']
                });

                //下拉列表
                form.on('select(city)', function (data) {
                    console.log(data.elem); //得到select原始DOM对象
                    console.log(data.value); //得到被选中的值
                    console.log(data.othis); //得到美化后的DOM对象
                });
                form.on('select(shoukuanfangshi)', function (data) {
                    console.log(data.elem); //得到select原始DOM对象
                    console.log(data.value); //得到被选中的值
                    console.log(data.othis); //得到美化后的DOM对象
                });
                form.on('select(firstclass)', function (data) {
                    console.log(data.elem); //得到select原始DOM对象
                    console.log(data.value); //得到被选中的值
                    console.log(data.othis); //得到美化后的DOM对象
                });
                form.on('select(secondclass)', function (data) {
                    console.log(data.elem); //得到select原始DOM对象
                    console.log(data.value); //得到被选中的值
                    console.log(data.othis); //得到美化后的DOM对象
                });
                form.on('select(leixing)', function (data) {
                    console.log(data.elem); //得到select原始DOM对象
                    console.log(data.value); //得到被选中的值
                    console.log(data.othis); //得到美化后的DOM对象
                });
                form.on('select(shangquan)', function (data) {
                    console.log(data.elem); //得到select原始DOM对象
                    console.log(data.value); //得到被选中的值
                    console.log(data.othis); //得到美化后的DOM对象
                });
                
                 form.on('submit(demo1)', function (data) {
			            console.log(data.elem) //被执行事件的元素DOM对象，一般为button对象
			            console.log(data.form) //被执行提交的form对象，一般在存在form标签时才会返回
			            console.log(data.field) //当前容器的全部表单字段，名值对形式：{name: value}
						var inputs=$("input[type='file']");
						var arr=[];
						inputs.each(function(a,b){
							arr.push($(b).val());
						})

			            return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。
			        });

            });
        </script>


    </form>
</body>
</html>
