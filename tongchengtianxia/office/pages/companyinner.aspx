﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="companyinner.aspx.vb" Inherits="office_pages_companyinner" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>公司内页</title>
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
								<cite>公司内页</cite>
							</li>
						</ul>
						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0; background: #fff;">
							<div class="layui-tab-item layui-show">
								<!--内容-->
								<div id="nav_name" name="内页管理">
									<div class="admin-main layui-form">
										<div class="layui-elem-quote">
											<div class="layui-input-inline lg">
												<input type="text" name="uesrname" placeholder="请输入用户名或订单号" autocomplete="off" class="layui-input">
											</div>
											<a href="javascript:;" class="layui-btn layui-btn-small" id="search">
												<i class="layui-icon">&#xe615;</i>搜索
											</a>
											<a href="/office/pages/addcompany.aspx" class="layui-btn layui-btn-small" id="addpage">
												<i class="layui-icon">&#xe608;</i> 添加内容
											</a>
										</div>
										<div class="admin-table-page">
											<div id="paged" class="page">
											</div>
										</div>
									</div>
									<fieldset class="layui-elem-field">
										<legend>内容列表</legend>
										<div class="layui-field-box layui-form">
											<table class="layui-table admin-table">
												<thead>
													<tr>
														<th style="width: 30px;"><input type="checkbox" lay-filter="allselector" lay-skin="primary"></th>
														<th>编号</th>
														<th>用户编号</th>
														<th>公司类目名称</th>
														<th>新闻标题</th>
														<th>内容</th>
														<th>发布时间</th>
														<th>操作</th>
													</tr>
												</thead>
												<tbody id="content">
													<tr>
														<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
														<td>1</td>
														<td>123456789</td>
														<td>公司公告</td>
														<td>清明放假</td>
														<td>清明放假清明放假清明放假清明放假清明放假清明放假</td>
														<td>2017-07-12 16：00</td>
														<td>
															<a href="/office/pages/addcompany.aspx" data-opt="edit" class="layui-btn  layui-btn-mini">修改</a>
															<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-danger layui-btn-mini del">删除</a>
														</td>
													</tr>
												</tbody>
											</table>
											<div id="fy_1"></div>
										</div>
									</fieldset>

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
				layui.use(['form', 'laypage', 'layer', "laydate"], function() {
					var laypage = layui.laypage,
						$ = layui.jquery,
						layer = layui.layer, //获取当前窗口的layer对象
						layerTips = parent.layer === undefined ? layui.layer : parent.layer, //获取父窗口的layer对象
						form = layui.form();

					//添加nav选中项
					var str = $("#nav_name").attr("name");
					$("dd[title=" + str + "]").addClass("layui-this").parents("li").addClass("layui-nav-itemed");

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

					$(".del").click(function() {
						$(this).parents("tr").remove();
					});

					//全选
					form.on('checkbox(allselector)', function(data) {
						var child = $(data.elem).parents('table').find('tbody input[type="checkbox"]');
						child.each(function(index, item) {
							item.checked = data.elem.checked;
						});
						form.render('checkbox');
					});
					

				});
			</script>
			
		</form>
	</body>

</html>