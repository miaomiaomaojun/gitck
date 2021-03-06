﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="newsku.aspx.vb" Inherits="office_pages_newsku" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>新闻管理</title>
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
								<cite>新闻管理</cite>
							</li>
						</ul>
						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0; background: #fff;">
							<div class="layui-tab-item layui-show">
								<!--内容-->
								<div id="nav_name" name="新闻管理">
									<div class="admin-main layui-form">
										<div class="layui-elem-quote">
											<a href="javascript:;" class="layui-btn layui-btn-small" id="addbank">
												<i class="layui-icon">&#xe608;</i> 添加新闻
											</a>
										</div>
										<div class="admin-table-page">
											<div id="paged" class="page">
											</div>
										</div>
									</div>
									<fieldset class="layui-elem-field">
										<legend>新闻列表</legend>
										<div class="layui-field-box layui-form">
											<table class="layui-table admin-table">
												<thead>
													<tr>
														<th style="width: 30px;"><input type="checkbox" lay-filter="allselector" lay-skin="primary"></th>
														<th>序号</th>
														<th>新闻名称</th>
														<th>操作</th>
													</tr>
												</thead>
												<tbody id="content">
													<tr>
														<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
														<td>1</td>
														<td>放假通知</td>
														<td>
															<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini bianji">查看</a>
															<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-danger layui-btn-mini del">删除</a>
															<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-normal layui-btn-mini">修改</a>
														</td>
													</tr>
													<tr>
														<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
														<td>2</td>
														<td>放假通知</td>
														<td>
															<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini bianji">查看</a>
															<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-danger layui-btn-mini del">删除</a>
															<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-normal layui-btn-mini">修改</a>
														</td>
													</tr>
													<tr>
														<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
														<td>3</td>
														<td>放假通知</td>
														<td>
															<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini bianji">查看</a>
															<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-danger layui-btn-mini del">删除</a>
															<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-normal layui-btn-mini ">修改</a>
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

			        $(".del").click(function () {
			            $(this).parents("tr").remove();
			        });

			        //全选
			        form.on('checkbox(allselector)', function (data) {
			            var child = $(data.elem).parents('table').find('tbody input[type="checkbox"]');
			            child.each(function (index, item) {
			                item.checked = data.elem.checked;
			            });
			            form.render('checkbox');
			        });

			        var bjBoxIndex = -1;
			        $("#addbank").on('click', function () {
			            if (bjBoxIndex !== -1) {
			                return;
			            }
			            bjBoxIndex = layer.open({
			                type: 1,
			                title: '添加单位',
			                content: $("#tanchuang"),
			                btn: ['保存', '取消'],
			                shade: [0.6, '#393D49'],
			                offset: ['200px', '30%'],
			                area: ['550px', '180px'],
			                zIndex: 999,
			                maxmin: true,
			                yes: function (index) {
			                    //触发表单的提交事件
			                    $('div.layui-form').find('button[lay-filter=edit]').click();
			                },
			                full: function (elem) {
			                    var win = window.top === window.self ? window : parent.window;
			                    $(win).on('resize', function () {
			                        var $this = $(this);
			                        elem.width($this.width()).height($this.height()).css({
			                            top: 0,
			                            left: 0
			                        });
			                        elem.children('div.layui-layer-content').height($this.height() - 95);
			                    });
			                },
			                success: function (layero, index) {
			                    var form = layui.form();
			                    form.render();
			                    form.on('submit(edit)', function (data) {
			                        console.log(data.elem) //被执行事件的元素DOM对象，一般为button对象
			                        console.log(data.form) //被执行提交的form对象，一般在存在form标签时才会返回
			                        console.log(data.field) //当前容器的全部表单字段，名值对形式：{name: value}
			                        // 这里是发送命令，更改城市名称

			                        layer.close(index);
			                        return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。									
			                    });
			                },
			                end: function () {
			                    bjBoxIndex = -1;
			                }
			            });
			        });
			    });
			</script>
			<!--添加单位弹窗-->
			<div style="display:none;margin: 15px;" id="tanchuang">
				<div class="layui-form">
					<div class="layui-form-item">
						<label class="layui-form-label">单位名称</label>
						<div class="layui-input-inline">
							<input type="text" name="bankname" lay-verify="required" placeholder="请输入单位" autocomplete="off" class="layui-input">
						</div>
					</div>
					<button lay-filter="edit" lay-submit style="display: none;"></button>
				</div>
			</div>

		</form>
	</body>

</html>
