<%@ Page Language="VB" AutoEventWireup="false" CodeFile="tianjiashangpin.aspx.vb" Inherits="office_pages_tianjiashangpin" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>添加商品</title>
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
	<style>
		.layui-form-item {
			margin-bottom: 15px;
		}
		
		select {
			width: 190px;
		}
		
		.layui-layedit {
			height: 400px;
		}
	</style>

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
								<cite>添加商品</cite>
							</li>
						</ul>
						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0; background: #fff;">
							<div class="layui-tab-item layui-show">
								<!--内容-->
								<div id="nav_name" name="添加商品">
									<div style="padding: 15px;">
										<div class="layui-form" action="">
											<fieldset class="layui-elem-field">
												<legend>添加商品</legend>
												<div class="layui-field-box layui-form">

													<div class="layui-form-item">
														<label class="layui-form-label">活动编号</label>
														<div class="layui-input-inline">
															<input type="number" name="huodongbianhao" lay-verify="number" autocomplete="off" placeholder="请输入活动编号" class="layui-input" value="1234">
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">是否参加活动</label>
														<div class="layui-input-block">
															<input type="radio" name="canjia" value="1" title="是">
															<input type="radio" name="canjia" value="0" title="否" checked>
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">活动收益</label>
														<div class="layui-input-inline">
															<input type="text" name="shouyi" lay-verify="jiage" autocomplete="off" placeholder="¥" class="layui-input" value="125.5">
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">商铺编号</label>
														<div class="layui-input-inline">
															<input type="number" name="shangpubianhao" lay-verify="number" autocomplete="off" class="layui-input" value="1234">
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">首页封面图片</label>
														<div class="layui-input-inline">
															<!--layui使用时去掉box和span-->
															<div class="layui-box layui-upload-button">
																<input type="file" name="file1" class="layui-upload-file" id="upfm">
																<span class="layui-upload-icon"><i class="layui-icon"></i>上传图片</span>
															</div>
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label"></label>
														<div style="float: left">
															<img id="Imgfm" width="110" height="80" />
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">商品页面头图</label>
														<div class="layui-input-inline">
															<!--layui使用时去掉box和span-->
															<div class="layui-box layui-upload-button">
																<input type="file" name="file2" class="layui-upload-file" id="upgo">
																<span class="layui-upload-icon"><i class="layui-icon"></i>上传图片</span>
															</div>
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label"></label>
														<div style="float: left">
															<img id="Imggo" width="110" height="80" />
														</div>
													</div>

													<div class="layui-form-item">
														<label class="layui-form-label">手机封面图片</label>
														<div class="layui-input-inline">
															<!--layui使用时去掉box和span-->
															<div class="layui-box layui-upload-button">
																<input type="file" name="file3" class="layui-upload-file" id="uppo">
																<span class="layui-upload-icon"><i class="layui-icon"></i>上传图片</span>
															</div>
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label"></label>
														<div style="float: left">
															<img id="ImgPo" width="110" height="80" />
														</div>
													</div>

													<div class="layui-form-item">
														<label class="layui-form-label">商品标题</label>
														<div class="layui-input-inline">
															<input type="text" name="title" lay-verify="feikongbai" autocomplete="off" placeholder="请输入商品标题" class="layui-input" value="黑椒牛柳鸡排">
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">简述</label>
														<div class="layui-input-block">
															<textarea name="jianshu" class="layui-textarea" lay-verify="length">我们家的鸡排采用纯天然老母鸡</textarea>
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">原价格</label>
														<div class="layui-input-inline">
															<input type="text" id="yuanjia" name="yuanjia" lay-verify="jiage" autocomplete="off" class="layui-input" lay-ignore value="150">
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">结算价</label>
														<div class="layui-input-inline">
															<input type="text" id="jiesuanjia" name="jiesuanjia" lay-verify="jiage" autocomplete="off" class="layui-input" lay-ignore>
														</div>
													</div>

													<div class="layui-form-item">
														<div class="layui-inline">
															<label class="layui-form-label">同城价</label>
															<div class="layui-input-inline">
																<input type="text" id="tongchengjia" name="tongchengjia" lay-verify="jiage" autocomplete="off" class="layui-input" disabled>
															</div>
															<label class="layui-form-label">赠送积分</label>
															<div class="layui-input-inline">
																<input type="text" id="zengsongjifen" name="zengsongjifen" lay-verify="jiage" autocomplete="off" class="layui-input" disabled>
															</div>
														</div>
													</div>
													<div class="layui-form-item">
														<label class="layui-form-label">积分价</label>
														<div class="layui-input-inline">
															<input type="text" id="jifenjia" name="jifenjia" lay-verify="jiage" autocomplete="off" class="layui-input" disabled>
														</div>
														<label class="layui-form-label">扣除积分</label>
														<div class="layui-input-inline">
															<input type="text" id="kouchujifen" name="kouchujifen" lay-verify="jiage" autocomplete="off" class="layui-input" disabled>
														</div>
													</div>
													<div class="layui-form-item">
														<div class="layui-inline">
															<label class="layui-form-label">开始时间</label>
															<div class="layui-input-block">
																<input type="text" name="date1" id="date" lay-verify="date" placeholder="yyyy-mm-dd" autocomplete="off" class="layui-input" onclick="layui.laydate({ elem: this })">
															</div>
														</div>
														<div class="layui-inline">
															<label class="layui-form-label">结束时间</label>
															<div class="layui-input-block">
																<input type="text" name="date2" id="Text1" lay-verify="date" placeholder="yyyy-mm-dd" autocomplete="off" class="layui-input" onclick="layui.laydate({ elem: this })">
															</div>
														</div>
													</div>

													<div class="layui-form-item">
														<label class="layui-form-label">内容描述</label>
														<div class="layui-input-block">
															<textarea id="fuwenben" name="neirong">好吃的鸡排，好吃的牛柳，好吃的鸡排，好吃的牛柳，好吃的鸡排，好吃的牛柳，好吃的鸡排，好吃的牛柳，好吃的鸡排，好吃的牛柳</textarea>
														</div>
													</div>

													<div class="layui-form-item">
														<div class="layui-input-block">
															<button class="layui-btn" lay-submit="" lay-filter="demo1">立即提交</button>
															<button type="button" class="layui-btn layui-btn-primary" id="back">返回</button>
														</div>
													</div>
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
			<script type="text/javascript" src="/office/plugins/layui/layui.js"></script>
			<script type="text/javascript" src="/office/js/index.js"></script>
			<script src="/js/jquery-1.11.0.js" type="text/javascript" charset="utf-8"></script>
			<script src="/js/JQ_tupianyulan.js" type="text/javascript" charset="utf-8"></script>
			<script>
				$("#upfm").uploadPreview({
					Img: "Imgfm",
					Width: 120,
					Height: 120,
					ImgType: ["gif", "jpeg", "jpg", "bmp", "png"],
					Callback: function() {}
				});
				$("#upgo").uploadPreview({
					Img: "Imggo",
					Width: 120,
					Height: 120,
					ImgType: ["gif", "jpeg", "jpg", "bmp", "png"],
					Callback: function() {}
				});
				$("#uppo").uploadPreview({
					Img: "ImgPo",
					Width: 120,
					Height: 120,
					ImgType: ["gif", "jpeg", "jpg", "bmp", "png"],
					Callback: function() {}
				});
				layui.config({
					base: '/office/js/'
				});
				layui.use(['form', 'laypage', 'layer', 'laydate', 'upload', 'layedit'], function() {
					var laypage = layui.laypage,
						$ = layui.jquery,
						layer = layui.layer, //获取当前窗口的layer对象
						layerTips = parent.layer === undefined ? layui.layer : parent.layer, //获取父窗口的layer对象
						form = layui.form();

					form.verify({
						jiage: [/(^[0-9]*[1-9][0-9]*$)|(^([0-9]{1,}.?[0-9]{0,2})$)/, '价格的格式不正确'],
						feikongbai: [/^\S{1,20}$/, '请输入1到20个非空白字符'],
						length: [/^[\s\S]{0,100}$/, '请输入1到100个字符']
					});
					form.render();
					var layedit = layui.layedit;
					layedit.build('fuwenben', {
						'height': 200
					}); //建立编辑器

					$("#back").click(function() {
						history.go(-1);
					})

					//添加nav选中项
					var str = $("#nav_name").attr("name");
					$("dd[title=" + str + "]").addClass("layui-this").parents("li").addClass("layui-nav-itemed");

					$("#jiesuanjia,#yuanjia").change(function() {
						if(($("#jiesuanjia").val() != "") && ($("#yuanjia").val() != "")) {
							var jiesuanjia = parseFloat($("#jiesuanjia").val());
							var yuanjia = parseFloat($("#yuanjia").val());
							var tongchengjia, zengsongjifen, jifenjia, kouchujifen;
							if((jiesuanjia / yuanjia >= 0.5) && (jiesuanjia / yuanjia < 1)) {
								tongchengjia = yuanjia * (jiesuanjia / yuanjia + 0.05);
								tongchengjia = parseInt(tongchengjia * 100) / 100;
								zengsongjifen = parseInt((tongchengjia - jiesuanjia) / 0.3);
								jifenjia = yuanjia / 2;
								jifenjia = parseInt(jifenjia * 100) / 100;
								kouchujifen = parseInt(jifenjia / 0.3);
							} else if((jiesuanjia / yuanjia < 0.5) && (jiesuanjia / yuanjia > 0)) {
								tongchengjia = jiesuanjia / 0.8 * 0.85;
								tongchengjia = parseInt(tongchengjia * 100) / 100;
								zengsongjifen = parseInt((tongchengjia - jiesuanjia) / 0.3);
								jifenjia = jiesuanjia / 1.6;
								jifenjia = parseInt(jifenjia * 100) / 100;
								kouchujifen = parseInt(jifenjia / 0.3)
							} else {
								alert("输入价格错误");
							}
							console.log(tongchengjia);
							console.log(zengsongjifen);
							console.log(jifenjia);
							console.log(kouchujifen);

							$("#tongchengjia").val(tongchengjia);
							$("#zengsongjifen").val(zengsongjifen);
							$("#jifenjia").val(jifenjia);
							$("#kouchujifen").val(kouchujifen);

						} else {

						}
					})

					form.on('submit(demo1)', function(data) {
						console.log(data.elem) //被执行事件的元素DOM对象，一般为button对象
						console.log(data.form) //被执行提交的form对象，一般在存在form标签时才会返回
						console.log(data.field) //当前容器的全部表单字段，名值对形式：{name: value}
						var inputs = $("input[type='file']");
						var arr = [];
						inputs.each(function(a, b) {
							arr.push($(b).val());
						})
						console.log(arr)

						return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。
					});

				});
			</script>

		</form>
	</body>

</html>