<%@ Page Language="VB" AutoEventWireup="false" CodeFile="addbanner.aspx.vb" Inherits="office_pages_addbanner" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>添加banner图</title>
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
								<cite>添加banner图</cite>
							</li>
						</ul>
						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0; background: #fff;">
							<div class="layui-tab-item layui-show">
								<!--内容-->
								<div id="nav_name" name="banner图管理">
									<div style="padding: 15px;">
										<div class="layui-form">
											<div class="layui-form-item">
												<label class="layui-form-label">分类选择</label>
												<div class="layui-input-inline">
													<select name="" id="" lay-filter="fenlei">
														<option value="1">电脑端</option>
														<option value="2">手机端</option>
													</select>
												</div>
											</div>
                                            <div class="layui-form-item">
												<label class="layui-form-label">类型</label>
												<div class="layui-input-inline">
													<select name="" id="Select1" lay-filter="leixing">
														<option value="1">1商品</option>
														<option value="2">2广告</option>
                                                        <option value="3">3活动</option>
                                                        <option value="4">4</option>
                                                        <option value="5">5</option>
													</select>
												</div>
											</div>
											<div class="layui-form-item">
												<label class="layui-form-label">图片</label>
												<div class="layui-input-inline">
													<!--layui使用时去掉box和span-->
													<div class="layui-box layui-upload-button">
														<input type="file" name="file" class="layui-upload-file" id="up">
														<span class="layui-upload-icon"><i class="layui-icon"></i>上传图片</span>
													</div>
												</div>
											</div>
											<div class="layui-form-item">
												<label class="layui-form-label"></label>
												<div style="float: left">
													<img id="ImgPr" width="110" height="80" />
												</div>
											</div>
											<div class="layui-form-item">
												<label class="layui-form-label">绑定地址</label>
												<div class="layui-input-inline">
													<input type="text" name="adress" lay-verify="required" autocomplete="off" class="layui-input">
												</div>
											</div>

											<div class="layui-form-item">
												<label class="layui-form-label">排序</label>
												<div class="layui-input-inline">
													<input type="number" name="city" lay-verify="number" autocomplete="off" class="layui-input">
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
			<script src="/js/jquery-1.11.0.js" type="text/javascript" charset="utf-8"></script>
			<script src="/js/JQ_tupianyulan.js" type="text/javascript" charset="utf-8"></script>
			<script>
				$("#up").uploadPreview({
					Img: "ImgPr",
					Width: 120,
					Height: 120,
					ImgType: ["gif", "jpeg", "jpg", "bmp", "png"],
					Callback: function() {}
				});
				layui.config({
					base: '/office/js/'
				});
				layui.use(['form', 'laypage', 'layer', 'laydate', 'upload'], function() {
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
					$("dd[title=" + str + "]").addClass("layui-this").parents("li").addClass("layui-nav-itemed");

					//下拉列表
					form.on('select(fenlei)', function(data) {
						console.log(data.elem); //得到select原始DOM对象
						console.log(data.value); //得到被选中的值
						console.log(data.othis); //得到美化后的DOM对象
					}); 
					form.on('select(leixing)', function (data) {
					    console.log(data.elem); //得到select原始DOM对象
					    console.log(data.value); //得到被选中的值
					    console.log(data.othis); //得到美化后的DOM对象
					});
				});
			</script>

		</form>
	</body>

</html>