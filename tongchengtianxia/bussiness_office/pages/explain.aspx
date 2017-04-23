<%@ Page Language="VB" AutoEventWireup="false" CodeFile="explain.aspx.vb" Inherits="bussiness_office_plugins_explain" %>
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
	<link rel="stylesheet" href="/bussiness_office/css/global.css" media="all">
	<link rel="stylesheet" href="/bussiness_office/plugins/font-awesome/css/font-awesome.min.css">
    <link rel="stylesheet" href="/bussiness_office/css/pikaday.css">
    <link rel="stylesheet" href="/bussiness_office/css/officehomepage.css" />
    <link rel="stylesheet" href="/bussiness_office/css/laypage.css" />
    <link rel="stylesheet" href="/bussiness_office/css/explain.css" />
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
<div class="layui-layout layui-layout-admin">
    <uc1:top runat="server" ID="top" />
       <uc1:left_link runat="server" ID="left_link" />
     <div class="layui-body" style="bottom:40px;border-left: solid 2px #00c1de;min-width: 924px;background: #f2f2f2;" id="admin-body">

           <div class="ind-box">
               <div class="mslaf-omw"><div class="shop" title="评价管理">评价管理</div></div>
                <div class="box-qls">
                    <span class="span-box">您可以在这里对用户的评价进行解释说明</span>
                    <div class="marleft-box">
                     <form action="#" method="post">
                     <table class="layui-table uw-lad" lay-even lay-skin="nob">
                                <colgroup>
                                             <col width="120">
                                              <col width="">
                                                 <col>
                                 </colgroup>
                                 <tbody>
                                                 <tr>
                                                     <td class="ladws">用户昵称：</td>
                                                     <td><span>ctxt12345678900</span></td>
                                                 </tr>
                                                  <tr>
                                                     <td  class="ladws">评价内容：</td>
                                                      <td><span>味道果然不错，更妙的是使用同城天下平台送的积分和抽奖现金消费，10元的面居然没话一分钱，真心太棒了！ </span></td>
                                                  </tr>
                                                  <tr>
                                                     <td  class="ladws">评价图片：</td>
                                                      <td><span><img src="/bussiness_office/images/min-pos.png" class="min-pos"><img src="/bussiness_office/images/min-pos.png" class="min-pos"><img src="/bussiness_office/images/min-pos.png" class="min-pos"></span></td>
                                                  </tr>
                                                  <tr>
                                                     <td  class="ladws pos-iton">解释说明：</td>
                                                      <td><textarea rows="9" name="" class="are-text"></textarea></td>
                                                  </tr>
                                                   <tr>
                                                  <td></td>
                                                      <td><div class="max-colortext">解释说明最多为200个字符</div></td>
                                                  </tr>
                                                                                        <tr>
                                                  <td></td>
                                                       <td  class="ladws gray"><button class="layui-btn us-btn" lay-submit lay-filter="formDemo">立即提交</button><button class="layui-btn layui-btn-primary" lay-submit lay-filter="formDemo">取消</button></td>

                                                  </tr>
                                  </tbody>
                            </table>
                         </form>
                    </div>
                </div>
           </div>
     </div>
                    <uc1:bottom runat="server" ID="bottom" />
</div>
             <script type="text/javascript" src="/bussiness_office/js/jquery-1.11.0.js"></script>
        <script type="text/javascript" src="/bussiness_office/plugins/layui/layui.js"></script>
		<script type="text/javascript" src="/bussiness_office/js/index.js"></script>
		<script type="text/javascript" src="/bussiness_office/js/pikaday.js"></script>
		<script type="text/javascript" src="/bussiness_office/js/pikaday.jquery.js"></script>
		<script type="text/javascript" src="/bussiness_office/js/homepage.js"></script>
		<script type="text/javascript" src="/bussiness_office/js/laypage.js"></script>
		<script type="text/javascript" src="/bussiness_office/js/explain.js"></script>
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
</body>
</html>
