<%@ Page Language="VB" AutoEventWireup="false" CodeFile="class.aspx.vb" Inherits="office_pages_class" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>类目管理</title>
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
				<div class="layui-body" style="bottom: 0;border-left: solid 2px #00c1de;" id="admin-body">
					<div class="layui-tab admin-nav-card layui-tab-brief" lay-filter="admin-tab">
						<ul class="layui-tab-title">
							<li class="layui-this">
								<i class="fa fa-dashboard" aria-hidden="true"></i>
								<cite>类目管理</cite>
							</li>
						</ul>
						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0;background: #fff;">
							<div class="layui-tab-item layui-show">
								<!--内容-->
								<div id="nav_name" name="类目管理">
									<fieldset class="layui-elem-field" style="width: 650px;float: left;">
										<legend>一级类目</legend>
										<div class="layui-field-box layui-form">
											<div class="layui-elem-quote">
												<a href="/office/pages/addclass.aspx" class="layui-btn layui-btn-small" id="addcity">
													<i class="layui-icon">&#xe608;</i> 添加一级类目
												</a>
												<div class="admin-table-page">
													<div id="paged" class="page">
													</div>
												</div>
											</div>
											<table class="layui-table admin-table">
												<thead>
													<tr>
														<th style="width: 30px;"><input type="checkbox" lay-filter="allselector" lay-skin="primary"></th>
														<th>类目名称</th>
														<th>图标</th>
														<th>排序</th>
														<th>推荐</th>
														<th>操作</th>
													</tr>
												</thead>
												<tbody id="content">
													<tr>
														<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
														<td class="firstclassname">美食</td>
														<td>
															<div class="imgs"><img src="../images/0.jpg" alt="" /></div>
														</td>
														<td>255</td>
														<td>否</td>
														<td>
															<a href="/office/pages/addclass.aspx" data-opt="edit" class="layui-btn layui-btn-mini bianji">编辑</a>
															<a href="javascript:;" data-opt="del" class="layui-btn layui-btn-danger layui-btn-mini del">删除</a>
															<a href="javascript:;" data-opt="chakan" class="layui-btn layui-btn-normal layui-btn-mini chakan">查看二级类目</a>
														</td>
													</tr>
													<tr>
														<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
														<td class="firstclassname">旅游</td>
														<td>
															<div class="imgs"><img src="../images/0.jpg" alt="" /></div>
														</td>
														<td>255</td>
														<td>否</td>
														<td>
															<a href="/office/pages/addclass.aspx" data-opt="edit" class="layui-btn layui-btn-mini bianji">编辑</a>
															<a href="javascript:;" data-opt="del" class="layui-btn layui-btn-danger layui-btn-mini del">删除</a>
															<a href="javascript:;" data-opt="chakan" class="layui-btn layui-btn-normal layui-btn-mini chakan">查看二级类目</a>
														</td>
													</tr>
												</tbody>
											</table>
											<!--分页器-->
											<div id="fy_1"></div>
										</div>
									</fieldset>
									<fieldset class="layui-elem-field" style="width: 650px;float: left;display: none;" id="secondclass">
										<legend>二级类目</legend>
										<div class="layui-field-box layui-form">
											<div class="layui-elem-quote">
												<p class="layui-input-inline" id="secondclass_first">美食</p>
												<a href="/office/pages/addclass.aspx" class="layui-btn layui-btn-small" id="addfirstclass">
													<i class="layui-icon">&#xe608;</i> 添加二级类目
												</a>
												<div class="admin-table-page">
													<div id="paged" class="page"></div>
												</div>
											</div>
											<table class="layui-table admin-table">
												<thead>
													<tr>
														<th style="width: 30px;"><input type="checkbox" lay-filter="allselector" lay-skin="primary"></th>
														<th>类目名称</th>
														<th>图标</th>
														<th>排序</th>
														<th>推荐</th>
														<th>操作</th>
													</tr>
												</thead>
												<tbody id="content">
													<tr>
														<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
														<td>火锅</td>
														<td>
															<div class="imgs"><img src="../images/0.jpg" alt="" /></div>
														</td>
														<td>255</td>
														<td>否</td>
														<td>

															<a href="/office/pages/addclass.aspx" data-opt="edit" class="layui-btn layui-btn-mini bianji">编辑</a>
															<a href="javascript:;" data-id="1" data-opt="del" class="layui-btn layui-btn-danger layui-btn-mini del">删除</a>
														</td>
													</tr>
													<tr>
														<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
														<td>烧烤</td>
														<td>
															<div class="imgs"><img src="../images/0.jpg" alt="" /></div>
														</td>
														<td>255</td>
														<td>否</td>
														<td>

															<a href="/office/pages/addclass.aspx" data-opt="edit" class="layui-btn layui-btn-mini bianji">编辑</a>
															<a href="javascript:;" data-id="1" data-opt="del" class="layui-btn layui-btn-danger layui-btn-mini del">删除</a>
														</td>
													</tr>
												</tbody>
											</table>
											<!--分页器-->
											<div id="fy_2"></div>
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

					//查看二级类目
					$(".chakan").on("click",function() {
						$("#secondclass").show();
						var $tr = $(this).parents("tr"),
							firstclassname = $tr.children(".firstclassname").html();
						$("#secondclass_first").html(firstclassname);
						//这里需要获取一级类目下的二级类目列表
					
					});	

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
					laypage({
						cont: 'fy_2',
						pages: 10 //总页数
							,
						groups: 5 //连续显示分页数
							,
						first: "首页",
						last: "末页",
						prev: "上一页",
						next: "下一页",
						skip: true
					});
					
					/*删除*/
					$(".del").click(function() {
						$(this).parents("tr").remove();
					});
					
				});
			</script>
		</form>
	</body>

</html>