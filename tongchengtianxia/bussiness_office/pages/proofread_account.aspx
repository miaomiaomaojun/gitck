<%@ Page Language="VB" AutoEventWireup="false" CodeFile="proofread_account.aspx.vb" Inherits="bussiness_office_pages_proofread_account" %>

<%@ Register Src="~/bussiness_office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/bussiness_office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/bussiness_office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>对账查询</title>
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
			float: left;
			border-bottom: 3px #00c1de solid;
			margin-top: 26px;
			margin-left: 10px;
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
								<div id="nav_name" name="对账查询">
									<div style="padding: 15px;">
										<div class="layui-form">
											<fieldset class="layui-elem-field">
												<div class="form-title">
													<p>对账查询</p>
												</div>
												<div class="layui-field-box layui-form">
													<div>
														<label class="layui-form-label">商品名称：</label>
														<div class="layui-input-inline">
															<input type="text" name="text" autocomplete="off" class="layui-input">
														</div>
														<a href="javascript:;" class="layui-btn layui-btn-primary layui-btn-small" id="search">
															<i class="layui-icon">&#xe615;</i> 查询
														</a>
													</div>
													<table class="layui-table" lay-skin="line">
														<thead>
															<tr>
																<th style="width: 30px;"><input type="checkbox" lay-filter="allselector" lay-skin="primary"></th>
																<th>编号</th>
																<th>订单号</th>
																<th>商品名称</th>
																<th>时间</th>
																<th>销量</th>
																<th>单价</th>
																<th>总计</th>
															</tr>
														</thead>
														<tbody id="content">
															<tr>
																<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																<td>1</td>
																<td>123456789987654321</td>
																<td>沈场砂锅麻辣烫30元套餐1份，免预约</td>
																<td>2017-04-15 09：21</td>
																<td>300</td>
																<td>20.5</td>
																<td>
																	5100元
																</td>
															</tr>

														</tbody>
													</table>
													<!--分页器-->

												</div>

												<div class="fenyebox">
													<div class="fy_1" id="fy_1"></div>
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

					laypage({
						cont: 'fy_1',
						pages: 10, //总页数
						groups: 5, //连续显示分页数
						first: "首页",
						last: "末页",
						prev: "上一页",
						next: "下一页",
						skip: true
					});
					//全选
					form.on('checkbox(allselector)', function(data) {
						var child = $(data.elem).parents('table').find('tbody input[type="checkbox"]');
						child.each(function(index, item) {
							item.checked = data.elem.checked;
						});
						form.render('checkbox');
					});
					$(".del").click(function() {
						$(this).parents("tr").remove();
					});

				});
			</script>

		</form>
	</body>

</html>