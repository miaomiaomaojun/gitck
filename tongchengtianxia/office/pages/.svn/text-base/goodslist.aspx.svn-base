<%@ Page Language="VB" AutoEventWireup="false" CodeFile="goodslist.aspx.vb" Inherits="office_pages_goodslist" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>商品列表</title>
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
			td img{width: 92px;height: 44px;}
			select{
				width: 120px;
				border: 1px solid #e6e6e6;
			}
		</style>
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
								<cite>商品列表</cite>
							</li>
						</ul>
						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0; background: #fff;">
							<div class="layui-tab-item layui-show">
								<!--内容-->
								<div id="nav_name" name="商品列表">
									<div class="admin-main layui-form">
										<div class="layui-elem-quote">
											<div class="layui-input-inline">
												<select name="" id="" lay-filter="firstclass">
													<option value="0">一级类目</option>
													<option value="1">美食</option>
													<option value="2">旅游</option>
													<option value="3">美容</option>
												</select>
											</div>
											<div class="layui-input-inline">
												<select name="" id="" lay-filter="secondclass">
													<option value="0">二级类目</option>
													<option value="1">火锅</option>
													<option value="2">披萨</option>
													<option value="3">小吃</option>
												</select>											
											</div>
											<div class="layui-input-inline">
												<input type="text" name="text" placeholder="请输入商品编号" autocomplete="off" class="layui-input">
											</div>
											<a href="javascript:;" class="layui-btn layui-btn-small" id="search">
												<i class="layui-icon">&#xe615;</i> 搜索
											</a>
											<a href="/office/pages/addgoods.aspx" class="layui-btn layui-btn-small" id="add">
											    <i class="layui-icon">&#xe608;</i> 添加商品
										    </a>
										</div>
										
										<div class="admin-table-page">
											<div id="paged" class="page">
											</div>
										</div>
									</div>
									<fieldset class="layui-elem-field">
										<legend>商品列表</legend>
										<div class="layui-field-box layui-form">
											<table class="layui-table admin-table">
												<thead>
													<tr>
														<th style="width: 30px;"><input type="checkbox" lay-filter="allselector" lay-skin="primary"></th>
														<th>时间</th>
                                                        <th>活动编号</th>
														<th>是否参加活动</th>
                                                        <th>活动收益</th>
                                                        <th>商铺编号</th>                                                       
														<th>首页封面图片</th>
														<th>商品页面头图</th>
														<th>手机端封面图片</th>
														<th>商品标题</th>
                                                        <th>原价格</th>
                                                        <th>同城价</th>
                                                        <th>赠送积分</th>
                                                        <th>结算价</th>
                                                        <th>积分价格</th>
                                                        <th>补价积分</th>
                                                        <th>结束时间</th>
                                                        <th>店铺状态</th>
                                                        <th>网站管理员操作</th>
                                                        <th>创建时间</th>
                                                        <th>操作</th>
													</tr>
												</thead>
												<tbody id="content">
													<tr>
														<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
														<td>8:00</td>
														<td>05879513</td>
														<td>是</td>
														<td>200.00</td>
														<td>123456</td>
														<td class=""><img src="" alt="" /></td>
														<td class=""><img src="" alt="" /></td>
														<td class=""><img src="" alt="" /></td>
														<td>单人套餐</td>
														<td>100.00</td>
														<td>80.00</td>
														<td>+100</td>
														<td>1</td>
														<td>50.00</td>
														<td>-100</td>
														<td>11:09</td>
														<td>1</td>
														<td>
															<div>
																<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini ">上架</a>
															</div>
															<div>
																<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-danger layui-btn-mini ">下架</a>
															</div>
														</td>
														<td>08:00</td>
														<td>
															<div>
																<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini chuli">修改</a>
															</div>
															<div>
																<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-danger layui-btn-mini del">删除</a>
															</div>
														</td>
													</tr>
													<tr>
														<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
														<td>8:00</td>
														<td>05879513</td>
														<td>是</td>
														<td>200.00</td>
														<td>123456</td>
														<td class=""><img src="" alt="" /></td>
														<td class=""><img src="" alt="" /></td>
														<td class=""><img src="" alt="" /></td>
														<td>单人套餐</td>
														<td>100.00</td>
														<td>80.00</td>
														<td>+100</td>
														<td>1</td>
														<td>50.00</td>
														<td>-100</td>
														<td>11:09</td>
														<td>1</td>
														<td>
															<div>
																<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini ">上架</a>
															</div>
															<div>
																<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-danger layui-btn-mini ">下架</a>
															</div>
														</td>
														<td>08:00</td>
														<td>
															<div>
																<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini chuli">修改</a>
															</div>
															<div>
																<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-danger layui-btn-mini del">删除</a>
															</div>
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
			    layui.use(['form', 'laypage', 'layer', "laydate"], function () {
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

					//下拉
					form.on('select(firstclass)', function(data){
						  console.log(data.elem); //得到select原始DOM对象
						  console.log(data.value); //得到被选中的值
						  console.log(data.othis); //得到美化后的DOM对象
					});
					//下拉
					form.on('select(secondclass)', function(data){
						  console.log(data.elem); //得到select原始DOM对象
						  console.log(data.value); //得到被选中的值
						  console.log(data.othis); //得到美化后的DOM对象
					});

			        //全选
			        form.on('checkbox(allselector)', function (data) {
			            var child = $(data.elem).parents('table').find('tbody input[type="checkbox"]');
			            child.each(function (index, item) {
			                item.checked = data.elem.checked;
			            });
			            form.render('checkbox');
			        });
			        
			         $(".del").click(function () {
			            $(this).parents("tr").remove();
			        });

			    });
			</script>
			
		</form>
	</body>

</html>