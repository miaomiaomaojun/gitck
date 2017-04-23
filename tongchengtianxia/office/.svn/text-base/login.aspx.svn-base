<%@ Page Language="VB" AutoEventWireup="false" CodeFile="login.aspx.vb" Inherits="office_login" %>

<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录</title>
    <meta name="renderer" content="webkit">
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
	<meta name="apple-mobile-web-app-status-bar-style" content="black">
	<meta name="apple-mobile-web-app-capable" content="yes">
	<meta name="format-detection" content="telephone=no">
	<link rel="shortcut icon" href="/office/images/favicon.ico" />
	<link rel="stylesheet" href="/office/plugins/layui/css/layui.css" media="all" />
	<link rel="stylesheet" href="css/login.css" />
</head>
<body class="beg-login-bg">
    <form id="form1" runat="server">
    <div class="beg-login-box">
			<header>
				<h1>后台登录</h1>
			</header>
			<div class="beg-login-main">
				<div action="/manage/login" class="layui-form" method="post"><input name="__RequestVerificationToken" type="hidden" value="fkfh8D89BFqTdrE2iiSdG_L781RSRtdWOH411poVUWhxzA5MzI8es07g6KPYQh9Log-xf84pIR2RIAEkOokZL3Ee3UKmX0Jc8bW8jOdhqo81" />
					<div class="layui-form-item">
						<label class="beg-login-icon">
                        	<i class="layui-icon">&#xe612;</i>
                    	</label>
						<input type="text" name="userName" lay-verify="userName" autocomplete="off" placeholder="这里输入登录名" class="layui-input">
					</div>
					<div class="layui-form-item">
						<label class="beg-login-icon">
                        	<i class="layui-icon">&#xe642;</i>
                    	</label>
						<input type="password" name="password" lay-verify="password" autocomplete="off" placeholder="这里输入密码" class="layui-input">
					</div>
					<div class="layui-form-item">
						<div class="beg-pull-left beg-login-remember">
							<label>记住帐号？</label>
							<input type="checkbox" name="rememberMe" value="true" lay-skin="switch" checked title="记住帐号">
						</div>
						<div class="beg-pull-right">
							<button class="layui-btn layui-btn-primary" lay-submit lay-filter="login">
                            <i class="layui-icon">&#xe650;</i> 登录
                        </button>
						</div>
						<div class="beg-clear"></div>
					</div>
				</div>
			</div>
			<footer>
				<p>2017 ©徐州掌汇网络科技有限公司</p>
			</footer>
           
		</div>
		<script type="text/javascript" src="plugins/layui/layui.js"></script>
		<script>
		    layui.use(['layer', 'form'], function () {
		        var layer = layui.layer,
					$ = layui.jquery,
					form = layui.form();

		        form.on('submit(login)', function (data) {

		            location.href = 'index.aspx';
		            return false;
		        });
		    });
		</script>
    </form>
</body>
</html>
