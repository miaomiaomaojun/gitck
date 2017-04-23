<%@ Page Language="VB" AutoEventWireup="false" CodeFile="loginhistory.aspx.vb" Inherits="office_pages_loginhistory" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>








<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>登录记录</title>
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
		<style>
			td .imgs {
				width: 50px;
				height: 50px;
				border-radius: 50px;
				overflow: hidden;
			}
			
			td .imgs img {
				width: 50px;
				height: 50px;
			}
		</style>
	</head>

	<body>
		<form id="form1" runat="server">
			<div class="layui-layout layui-layout-admin" style="border-bottom: solid 5px #00c1de;">
                <uc1:top runat="server" ID="top" />
                <uc1:left_link runat="server" ID="left_link" />
				<!--右边开始-->
				<div class="layui-body" style="bottom: 0; border-left: solid 2px #00c1de;" id="admin-body">
					<div class="layui-tab admin-nav-card layui-tab-brief" lay-filter="admin-tab">
						<ul class="layui-tab-title">
							<li class="layui-this">
								<i class="fa fa-dashboard" aria-hidden="true"></i>
								<cite>登录记录</cite>
							</li>
						</ul>
						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0; background: #fff;">
							<div class="layui-tab-item layui-show">
								<!--内容-->
								<div id="nav_name" name="登录记录">
									<fieldset class="layui-elem-field">
										<legend>登录记录</legend>
										<div class="layui-field-box layui-form">
											<div class="layui-elem-quote">
												<div class="layui-input-inline lg">
												<input type="text" name="uesrname" placeholder="请输入内容" autocomplete="off" class="layui-input">
											</div>
											<a href="javascript:;" class="layui-btn layui-btn-small" id="search">
												<i class="layui-icon">&#xe615;</i>搜索
											</a>
											</div>
											<table class="layui-table admin-table">
												<thead>
													<tr>
                                                        <th style="width: 30px;"><input type="checkbox" lay-filter="allselector" lay-skin="primary"></th>
														<th>编号</th>
														<th>用户库编号</th>
                                                        <th>ip登录地址</th>
                                                        <th>登陆时间</th>
													</tr>
												</thead>
												<tbody id="content">
													<tr>
                                                        <td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
														<td>1</td>
														<td>11325</td>
														<td>192.163.1.1</td>
                                                        <td>2015-01-02 16：00</td>
													</tr>

												</tbody>
											</table>
											<!--分页器-->
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
			    layui.use(['form', 'laypage', 'layer', "laydate"], function () {
			        var laypage = layui.laypage,
						$ = layui.jquery,
						layer = layui.layer, //获取当前窗口的layer对象
						layerTips = parent.layer === undefined ? layui.layer : parent.layer, //获取父窗口的layer对象
						form = layui.form();
			        //添加nav选中项
			        var str = $("#nav_name").attr("name");
			        $("dd[title=" + str + "]").addClass("layui-this").parents("li").addClass("layui-nav-itemed");

			      

			        //分页
			        laypage({
			            cont: 'fy_1',
			            pages: 10,
			            groups: 5,
			            first: "首页",
			            last: "末页",
			            prev: "上一页",
			            next: "下一页",
			            skip: true
					});

					form.on('checkbox(allselector)', function(data) {
						var child = $(data.elem).parents('table').find('tbody input[type="checkbox"]');
						child.each(function(index, item) {
							item.checked = data.elem.checked;
						});
						form.render('checkbox');
					});/*删除*/
			       
			        

			    });
			</script>
			

		</form>
	</body>

</html>