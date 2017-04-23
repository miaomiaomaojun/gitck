<%@ Page Language="VB" AutoEventWireup="false" CodeFile="account_manage.aspx.vb" Inherits="bussiness_office_pages_account_manage" %>

<%@ Register Src="~/bussiness_office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/bussiness_office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/bussiness_office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>账号管理</title>
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
		<link rel="stylesheet" href="/bussiness_office/css/officehomepage.css" />
	</head>
	<style>
		* {
			font-family: "微软雅黑";
			font-size: 14px;
		}
		
		body {
			background: #f2f2f2;
		}
		
		.layui-form .layui-elem-field {
			min-height: 600px;
		}
		
		.layui-form .layui-elem-field .form-title {
			height:68px;
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
		
		.layui-form .layui-elem-field .layui-field-box {
			width: 650px;
			height: 400px;
			background: #FFFFFF;
			margin: 0 auto;
			margin-top: 130px;
			margin-bottom: 30px;
		}
		
		.layui-form-item {
			height: 100px;
			margin-bottom: 0;
		}
		
		.layui-form-item .layui-form-label {
			margin-left: 100px;
			margin-top: 30px;
		}
		
		.layui-form-item .layui-input-inline {
			margin-top: 30px;
		}
	</style>

	<body>
		<form id="form1" runat="server">
			<div class="layui-layout layui-layout-admin">
				<uc1:top runat="server" ID="top" />
				<uc1:left_link runat="server" ID="left_link" />
				<div class="layui-body" style="bottom: 0; border-left: solid 2px #00c1de;" id="admin-body">
					<div class="layui-tab admin-nav-card layui-tab-brief" lay-filter="admin-tab">

						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0;">
							<div class=" layui-show">
								<!--内容-->
								<div id="nav_name" name="账号管理">
									<div style="padding: 15px;">
										<div class="layui-form">
											<fieldset class="layui-elem-field">
												<div class="form-title">
													<p>账号管理</p>
												</div>
												<div class="layui-field-box">
													<div class="layui-form-item">
														<label class="layui-form-label">用户名</label>
														<div class="layui-input-inline">
															<input type="text" name="title" lay-verify="yonghuming" autocomplete="off" class="layui-input" value="nwsdsfsd" disabled="">
														</div>
													</div>

													<div class="layui-form-item">
														<label class="layui-form-label">原密码</label>
														<div class="layui-input-inline">
															<input type="password" id="yuanmima" name="yuanmima" lay-verify="mima" autocomplete="off" class="layui-input">
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">新密码</label>
														<div class="layui-input-inline">
															<input type="password" id="mima" name="mima" lay-verify="mima" autocomplete="off" placeholder="请输入5-15位新密码" class="layui-input">
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">确认密码</label>
														<div class="layui-input-inline">
															<input type="password" name="mimaqueren" lay-verify="mimaqueren" autocomplete="off" class="layui-input">
														</div>
													</div>
												</div>
												<div style="width: 165px;height: 50px;margin: 0 auto;margin-bottom: 120px;">
													<button class="layui-btn" lay-submit="" lay-filter="demo1">确认</button>
                                                    <button type="button" class="layui-btn layui-btn-primary" id="back">返回</button>
												</div>
											</fieldset>
										</div>

									</div>

								</div>
							</div>
						</div>
					</div>
				</div>
				<uc1:bottom runat="server" ID="bottom" />
			</div>
			<script type="text/javascript" src="/bussiness_office/plugins/layui/layui.js"></script>
			<script type="text/javascript" src="/bussiness_office/js/index.js"></script>
			<script>
				layui.config({
					base: '/bussiness_office/js/'
				});
				layui.use(['form', 'laypage', 'layer', 'laydate'], function() {
					var laypage = layui.laypage,
						$ = layui.jquery,
						layer = layui.layer, //获取当前窗口的layer对象
						layerTips = parent.layer === undefined ? layui.layer : parent.layer, //获取父窗口的layer对象
						form = layui.form();

					$("#back").click(function() {
						history.go(-1);
					})

					//添加nav选中项
					var str = $("#nav_name").attr("name");
					$("li[name=" + str + "]").addClass("layui-this");

					//验证
					form.verify({
						yonghuming: [/^[\u4e00-\u9fa5\w]{8,15}$/, '请输入8-15个字符'],
						feikongbai: [/^\S{1,20}$/, '请输入1到20个非空白字符'],
						mima: [/^.{5,15}$/, '请输入5到15个字符'],
						mimaqueren: function(value) {
							if($("#mima").val() !== value) {
								return '两次输入密码不一致';
							}
						}
					});
					//下拉
					form.on('select(quanxian)', function(data) {
						console.log(data.elem); //得到select原始DOM对象
						console.log(data.value); //得到被选中的值
						console.log(data.othis); //得到美化后的DOM对象
					});

					form.on('submit(demo1)', function(data) {
						console.log(data.elem) //被执行事件的元素DOM对象，一般为button对象
						console.log(data.form) //被执行提交的form对象，一般在存在form标签时才会返回
						console.log(data.field) //当前容器的全部表单字段，名值对形式：{name: value}

						return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。
					});

				});
			</script>

		</form>
	</body>

</html>