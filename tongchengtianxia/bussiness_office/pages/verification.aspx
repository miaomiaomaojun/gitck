<%@ Page Language="VB" AutoEventWireup="false" CodeFile="verification.aspx.vb" Inherits="bussiness_office_verification" %>
<%@ Register Src="~/bussiness_office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/bussiness_office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/bussiness_office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>后台管理主页</title>
    <meta name="renderer" content="webkit">
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
	<meta name="apple-mobile-web-app-status-bar-style" content="black">
	<meta name="apple-mobile-web-app-capable" content="yes">
	<meta name="format-detection" content="telephone=no">
	<link rel="shortcut icon" href="/bussiness_office/images/favicon.ico" />
	<link rel="stylesheet" href="/bussiness_office/plugins/layui/css/layui.css" media="all" />
    <link rel="stylesheet" href="/bussiness_office/css/laypage.css" />
    		<link rel="stylesheet" href="/bussiness_office/css/global.css" media="all">
    <link rel="stylesheet" href="/bussiness_office/plugins/font-awesome/css/font-awesome.min.css">
        		<link rel="stylesheet" href="/bussiness_office/css/officehomepage.css" />
    <link rel="stylesheet" href="/bussiness_office/css/verification.css" />
    	<style>
	body {
			background: #f2f2f2;
		}
		
		.layui-form .layui-elem-field {
			min-height: 600px;
			position: relative;
		}
		
		.layui-form .layui-elem-field .form-title {
			height: 68px;
			width: 100%;
			background: #FFFFFF;
		}
		
		.layui-form .layui-elem-field .form-title p {
			line-height: 40px;
			padding: 0 5px 0 5px;
			font-size: 18px;
			color: #444444;
            float:left;
            border-bottom:3px #00c1de solid;
            margin-top:26px;
            margin-left:10px;
		}
		
		.layui-input,
		.layui-select,
		.layui-textarea {
			height: 28px;
		}
		
		.layui-btn-small {
			height: 28px;
		}
		
		.layui-btn-small i {
			padding: 3px 5px;
			font-size: 13px!important;
		}
		
		.layui-form-label {
			padding: 5px 10px;
			text-align: left;
			width: 70px;
		}
		
		.layui-form .layui-elem-field .fenyebox {
			height: 60px;
			position: absolute;
			bottom: 0px;
			background: #FFFFFF;
			width: 100%;
		}
		
		.layui-form .layui-elem-field .fenyebox .fy_1 {
			float: right;
			margin-right: 10px;
			margin-top: 5px;
		}
		
		.layui-input,
		.layui-textarea {
			line-height: 28px;
		}
	</style>
</head>
<body>
  <form id="form1" runat="server">
    <div class="layui-layout layui-layout-admin">
      <uc1:top runat="server" ID="top" />
         <uc1:left_link runat="server" ID="left_link" />
            <div class="layui-body" style="bottom:40px;border-left: solid 2px #00c1de;min-width: 924px;background: #f2f2f2;" id="admin-body">
                <div class="ind-box">
                        <div class="mslaf-omw"><div class="shop" title="输码验证">输码验证</div></div>
                            <div class="ind-alert">
                              <div class="code-form"">
                                 <ladel>消费码:</ladel><input type="number" name="code-text" value="" class="kmsd">
                                        <button class="layui-btn cen-btn" lay-submit lay-filter="formDemo">确定</button>
                                            <div class="div-box"><!--输入有误-->
                                                    <i class="yns-list-iocn"></i><span>消费码输入错误,请重新输入</span>
                                                        </div><!--输入有误  结束-->
                              </div>
                           </div>
                            <div class="bd-color"></div><!--遮盖框-->
      <div class="sec"><!--优惠券已使用-->
        <div class="ico-box">  <i class="layui-icon">&#x1007;</i></div>
          <div class="alert-text">您该优惠券已于2017-01-01 20:20使用,请下个星期再次光临</div>
          <button class="err-min">确定</button>
      </div><!--优惠卷已使用 结束-->
      <div class="wmsa"><!--优惠券使用成功-->
        <div class="ico-box">  <i class="layui-icon">&#xe618;</i></div>
          <div class="title-secss">消费成功</div>
          <div class="alert-text">
                <ul>
                    <li>订单编号：<span>123456789123456789</span></li>
                    <li>手机号：<span>12345678912</span></li>
                    <li>支付方式：<span>支付宝</span></li>
                    <li>姓名：<span>赵山先生</span></li>
                    <li>商家：<span>重庆小面</span></li>
                 </ul>
          </div>
          <button class="err-min">确定</button>
      </div><!--优惠券使用成功  结束-->

    </div>
                
              <uc1:bottom runat="server" ID="bottom" />
</div>
 <script type="text/javascript" src="/office/js/jquery-1.11.0.js"></script>
  <script type="text/javascript" src="/office/plugins/layui/layui.js"></script>
    <script type="text/javascript" src="/office/js/index.js"></script>
	<script type="text/javascript" src="/office/js/pikaday.js"></script>
	<script type="text/javascript" src="/office/js/pikaday.jquery.js"></script>
	<script type="text/javascript" src="/office/js/homepage.js"></script>
    <script type="text/javascript" src="/office/js/verification.js"></script>
    <script>
        $(function () {
            $(".kmsd").bind('input propertychange', function () {
                var a=$(".kmsd").val();
                var sear = ".";
                if (!Number(a)) {
                    $(".div-box").show();
                }else {
                    $(".div-box").hide();
                }
             
            });
            
            $(".code-form").submit(function (e) {/*判断是否过期*/
                var sun = $(".kmsd").val();
                if (sun == "123456") {
                    $(".bd-color").fadeIn(300, function () {
                        $(".sec").show();

                    })

                    return false;
                }


            })
            $(".code-form").submit(function (e) {/*判断是否错误*/
                var sun = $(".kmsd").val();
                if (sun != "654321" && sun != "123456") {
                    $(".div-box").show();

                    return false;
                }
            })
            $(".code-form").submit(function (e) {/*判断是否成功*/
                var sun = $(".kmsd").val();
                if (sun == "654321") {
                    $(".bd-color").fadeIn(300, function () {
                        $(".wmsa").show();

                    })

                    return false;
                }


            })

            $(".err-min").on("click", function () {
                var jms = $(this);
                $(".bd-color").fadeOut(300, function () {
                    $(jms).parent().hide()
                })
               

            })



     })
    </script>
        <script>
            layui.config({
                base: '/bussiness_office/js/'
            });
            layui.use(['form', 'laypage', 'layer', 'laydate'], function () {
                var laypage = layui.laypage,
                    $ = layui.jquery,
                    layer = layui.layer, //获取当前窗口的layer对象
                    layerTips = parent.layer === undefined ? layui.layer : parent.layer, //获取父窗口的layer对象
                    form = layui.form();
            })
            $("#back").click(function () {
                history.go(-1);
            })
            var str = $(".shop").attr("title");
            $("li[name=" + str + "]").addClass("layui-this");

        </script>

</form>
</body>
</html>
