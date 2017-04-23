<%@ Page Language="VB" AutoEventWireup="false" CodeFile="shopapply.aspx.vb" Inherits="office_pages_shoppapply" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>店铺申请审核</title>
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
		select{
			width: 120px;
			border: 1px solid #e6e6e6;
		}
	</style>

	<body>
		<form id="form1" runat="server">
			<div class="layui-layout layui-layout-admin" style="border-bottom: solid 5px #00c1de;">
				<uc1:top runat="server" ID="top" />
				<uc1:left_link runat="server" ID="left_link" />
				<%--右边--%>
				<div class="layui-body" style="bottom: 0;border-left: solid 2px #00c1de;" id="admin-body">
					<div class="layui-tab admin-nav-card layui-tab-brief" lay-filter="admin-tab">
						<ul class="layui-tab-title">
							<li class="layui-this">
								<i class="fa fa-dashboard" aria-hidden="true"></i>
								<cite>店铺申请审核</cite>
							</li>
						</ul>
						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0;background: #fff;">
							<div class="layui-tab-item layui-show">
								<!--内容-->
								<div id="nav_name" name="店铺申请审核">
									<div class="layui-form">
										<div class="admin-main">
											<div class="layui-elem-quote">
												<div class="layui-input-inline">
													<select name="" id="" lay-filter="city">
														<option value="0">选择城市</option>
														<option value="1">徐州</option>
														<option value="2">南京</option>
														<option value="3">上海</option>
													</select>
												</div>
												<div class="layui-input-inline">
													<input type="text" name="text" placeholder="请输入店铺名称" autocomplete="off" class="layui-input">
												</div>
												<a href="javascript:;" class="layui-btn layui-btn-small" id="search">
													<i class="layui-icon">&#xe615;</i> 搜索
												</a>
											</div>

											<div class="admin-table-page">
												<div id="paged" class="page">
												</div>
											</div>
										</div>
									</div>

									<fieldset class="layui-elem-field">
										<legend>店铺申请列表</legend>
										<div class="layui-tab">
											<ul class="layui-tab-title">
												<li class="layui-this">待处理</li>
												<li>已处理</li>
												<li>不处理</li>
											</ul>
											<div class="layui-tab-content">
												<div class="layui-tab-item layui-show">
													<div class="layui-field-box layui-form">
														<table class="layui-table admin-table">
															<thead>
																<tr>
																	<th style="width: 30px;"><input type="checkbox" lay-filter="allselector" lay-skin="primary"></th>
																	<th>编号</th>
																	<th>姓名</th>
                                                                    <th>城市</th>
																	<th>联系电话</th>
																	<th>商铺名称</th>
																	<th>联系地址</th>
																	<th>时间</th>
																	<th>状态</th>
																	<th>操作</th>
																</tr>
															</thead>
															<tbody id="content">
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td class="username">李小花</td>
                                                                    <td>徐州</td>
																	<td>0516-885714</td>
																	<td>易保易购（徐州）网络科技有限公司</td>
																	<td>徐州市鼓楼区黄河北路90号淮海文化科技产业园</td>
																	<td>2017-03-02 </td>
																	<td>待处理</td>
																	<td>
																		<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini chuli">处理</a>
																		<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-danger layui-btn-mini buchuli">不处理</a>
																	</td>
																</tr>
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td class="username">李小花</td>
                                                                    <td>徐州</td>
																	<td>0516-885714</td>
																	<td>易保易购（徐州）网络科技有限公司</td>
																	<td>徐州市鼓楼区黄河北路90号淮海文化科技产业园</td>
																	<td>2017-03-02 </td>
																	<td>待处理</td>
																	<td>
																		<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini chuli">处理</a>
																		<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-danger layui-btn-mini buchuli">不处理</a>
																	</td>
																</tr>
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td class="username">李小花</td>
                                                                    <td>徐州</td>
																	<td>0516-885714</td>
																	<td>易保易购（徐州）网络科技有限公司</td>
																	<td>徐州市鼓楼区黄河北路90号淮海文化科技产业园</td>
																	<td>2017-03-02 </td>
																	<td>待处理</td>
																	<td>
																		<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini chuli">处理</a>
																		<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-danger layui-btn-mini buchuli">不处理</a>
																	</td>
																</tr>

															</tbody>
														</table>
														<div id="fy_1"></div>
													</div>
												</div>
												<div class="layui-tab-item">
													<div class="layui-field-box layui-form">
														<table class="layui-table admin-table">
															<thead>
																<tr>
																	<th style="width: 30px;"><input type="checkbox" lay-filter="allselector" lay-skin="primary"></th>
																	<th>编号</th>
																	<th>姓名</th>
																	<th>联系电话</th>
																	<th>商铺名称</th>
																	<th>联系地址</th>
																	<th>时间</th>
																	<th>状态</th>
																	<th>操作</th>
																</tr>
															</thead>
															<tbody id="content">
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td class="username">李小花</td>
																	<td>0516-885714</td>
																	<td>易保易购（徐州）网络科技有限公司</td>
																	<td>徐州市鼓楼区黄河北路90号淮海文化科技产业园</td>
																	<td>2017-03-02 </td>
																	<td>已处理</td>
																	<td>

																	</td>
																</tr>
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td class="username">李小花</td>
																	<td>0516-885714</td>
																	<td>易保易购（徐州）网络科技有限公司</td>
																	<td>徐州市鼓楼区黄河北路90号淮海文化科技产业园</td>
																	<td>2017-03-02 </td>
																	<td>已处理</td>
																	<td>

																	</td>
																</tr>
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td class="username">李小花</td>
																	<td>0516-885714</td>
																	<td>易保易购（徐州）网络科技有限公司</td>
																	<td>徐州市鼓楼区黄河北路90号淮海文化科技产业园</td>
																	<td>2017-03-02 </td>
																	<td>已处理</td>
																	<td>

																	</td>
																</tr>

															</tbody>
														</table>
														<div id="fy_2"></div>
													</div>
												</div>
												<div class="layui-tab-item">
													<div class="layui-field-box layui-form">
														<table class="layui-table admin-table">
															<thead>
																<tr>
																	<th style="width: 30px;"><input type="checkbox" lay-filter="allselector" lay-skin="primary"></th>
																	<th>编号</th>
																	<th>姓名</th>
																	<th>联系电话</th>
																	<th>商铺名称</th>
																	<th>联系地址</th>
																	<th>时间</th>
																	<th>状态</th>
																	<th>操作</th>
																</tr>
															</thead>
															<tbody id="content">
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td class="username">李小花</td>
																	<td>0516-885714</td>
																	<td>易保易购（徐州）网络科技有限公司</td>
																	<td>徐州市鼓楼区黄河北路90号淮海文化科技产业园</td>
																	<td>2017-03-02 </td>
																	<td>不处理</td>
																	<td></td>
																</tr>
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td class="username">李小花</td>
																	<td>0516-885714</td>
																	<td>易保易购（徐州）网络科技有限公司</td>
																	<td>徐州市鼓楼区黄河北路90号淮海文化科技产业园</td>
																	<td>2017-03-02 </td>
																	<td>不处理</td>
																	<td></td>
																</tr>
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td class="username">李小花</td>
																	<td>0516-885714</td>
																	<td>易保易购（徐州）网络科技有限公司</td>
																	<td>徐州市鼓楼区黄河北路90号淮海文化科技产业园</td>
																	<td>2017-03-02 </td>
																	<td>不处理</td>
																	<td></td>
																</tr>

															</tbody>
														</table>
														<div id="fy_3"></div>
													</div>
												</div>
											</div>
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
				layui.use(['form', 'laypage', 'layer', "laydate",'element'], function() {
					var laypage = layui.laypage,
						$ = layui.jquery,
						layer = layui.layer, //获取当前窗口的layer对象
						layerTips = parent.layer === undefined ? layui.layer : parent.layer, //获取父窗口的layer对象
						form = layui.form(),
						element = layui.element();

					//添加nav选中项
					var str = $("#nav_name").attr("name");
					$("dd[title=" + str + "]").addClass("layui-this").parents("li").addClass("layui-nav-itemed");

					//全选
					form.on('checkbox(allselector)', function(data) {
						var child = $(data.elem).parents('table').find('tbody input[type="checkbox"]');
						child.each(function(index, item) {
							item.checked = data.elem.checked;
						});
						form.render('checkbox');
					});
					
					//下拉
					form.on('select(city)', function(data){
						  console.log(data.elem); //得到select原始DOM对象
						  console.log(data.value); //得到被选中的值
						  console.log(data.othis); //得到美化后的DOM对象
					}); 
					
					//搜索
					$('#search').on('click', function() {
						parent.layer.alert('你点击了搜索按钮')
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
						pages: 10,
						groups: 5,
						first: "首页",
						last: "末页",
						prev: "上一页",
						next: "下一页",
						skip: true
					});
					laypage({
						cont: 'fy_3',
						pages: 10,
						groups: 5,
						first: "首页",
						last: "末页",
						prev: "上一页",
						next: "下一页",
						skip: true
					});

					$(".chuli").on('click', function() {

					});
					$(".buchuli").on('click', function() {

					});
				});
			</script>
			
		</form>
	</body>

</html>