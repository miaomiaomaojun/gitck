<%@ Page Language="VB" AutoEventWireup="false" CodeFile="add_activity.aspx.vb" Inherits="bussiness_office_pages_add_activity" %>

<%@ Register Src="~/bussiness_office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/bussiness_office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/bussiness_office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>活动管理</title>
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
			height: 68px;
			width: 100%;
			background: #FFFFFF;
		}
		
		.layui-form .layui-elem-field .form-title p {
			line-height: 40px;
			padding: 0 5px 0 5px;
			font-size: 18px;
			color: #444444;
			float: left;
			border-bottom: 3px #00c1de solid;
			margin-top: 26px;
			margin-left: 10px;
		}
		
		.layui-form .layui-elem-field .layui-field-box {
			width: 907px;
			height: 600px;
			background: #FFFFFF;
			margin: 0 auto;
			margin-top: 130px;
			margin-bottom: 30px;
		}
		
		.layui-form-item {
			margin-top: 30px;
			margin-bottom: 0;
		}
		
		.layui-form-item .layui-form-label {}
		
		.layui-form-label {
			width: 70px;
		}
		
		.layui-form-item .layui-input-block {
			margin-left: 100px;
			margin-right: 30px;
		}
		
		.layui-form-item .layui-input-inline {
			width: 333px;
		}
		
		.layui-btn-primary:hover {
			border-color: #00c1de;
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
								<div id="nav_name" name="活动管理">
									<div style="padding: 15px;">
										<div class="layui-form">
											<fieldset class="layui-elem-field">
												<div class="form-title">
													<p>活动</p>
												</div>
												<div class="layui-field-box layui-form">
													<div class="layui-form-item">
														<label class="layui-form-label">活动名称</label>
														<div class="layui-input-block">
															<input type="text" name="title" lay-verify="title" autocomplete="off" placeholder="请输入活动名称" class="layui-input">
														</div>
													</div>
													<div class="layui-form-item">

														<label class="layui-form-label">开始时间</label>
														<div class="layui-input-inline">
															<input type="text" name="date" id="date" lay-verify="date" placeholder="yyyy-mm-dd" autocomplete="off" class="layui-input" onclick="layui.laydate({elem: this})">
														</div>
														<label class="layui-form-label">结束时间</label>
														<div class="layui-input-inline">
															<input type="text" name="date" id="date" lay-verify="date" placeholder="yyyy-mm-dd" autocomplete="off" class="layui-input" onclick="layui.laydate({elem: this})">
														</div>

													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">活动数量</label>
														<div class="layui-input-block">
															<input lay-verify="number" autocomplete="off" placeholder="请输入活动数量" class="layui-input">
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">活动地点</label>
														<div class="layui-input-block">
															<input type="text" name="place" lay-verify="place" autocomplete="off" placeholder="请输入活动地点" class="layui-input">
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">活动价格</label>
														<div class="layui-input-block">
															<input lay-verify="number" autocomplete="off" placeholder="请输入活动价格" class="layui-input">
														</div>
													</div>
													<div class="layui-form-item layui-form-text">
														<label class="layui-form-label">活动介绍</label>
														<div class="layui-input-block">
															<textarea placeholder="请输入内容" class="layui-textarea"></textarea>
														</div>
														<div class="layui-form-item">
															<label class="layui-form-label">其他</label>
															<div class="layui-input-block">
																<input type="text" name="title" autocomplete="off" placeholder="" class="layui-input">
															</div>
														</div>
													</div>
												</div>
												<div style="width: 238px;height: 50px;margin: 0 auto;margin-bottom: 120px;">
													<button class="layui-btn" lay-submit="" lay-filter="demo1">确认</button>
													<button type="reset" class="layui-btn layui-btn-primary" id="back">取消</button>
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
						title: function(value) {
							if(value.length < 5) {
								return '活动名称不能为空';
							}
						},
						pass: [/(.+){6,12}$/, '密码必须6到12位'],
						content: function(value) {
							layedit.sync(editIndex);
						},
						place: function(value) {
							if(value.length < 5) {
								return '活动地点不能为空';
							}
						},
					});
					//下拉
					form.on('submit(demo1)', function(data) {
						layer.alert(JSON.stringify(data.field), {
							title: '最终的提交信息'
						})
						return false;
					});

				});
			</script>

		</form>
	</body>

</html>