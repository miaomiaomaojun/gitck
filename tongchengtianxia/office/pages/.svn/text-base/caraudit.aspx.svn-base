<%@ Page Language="VB" AutoEventWireup="false" CodeFile="caraudit.aspx.vb" Inherits="office_pages_caraudit" %>

<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>
<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>汽车认证审核</title>
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
			td img {
				width: 90px;
				height: 42px;
			}
		</style>
	</head>

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
								<cite>汽车认证</cite>
							</li>
						</ul>
						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0;background: #fff;">
							<div class="layui-tab-item layui-show">
								<!--内容-->
								<div id="nav_name" name="汽车认证审核">
									<div class="layui-form">
										<div class="admin-main">
											<div class="layui-elem-quote">
												<div class="layui-input-inline">
													<input type="text" name="text" placeholder="请输入内容" autocomplete="off" class="layui-input">
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
										<legend>汽车认证</legend>
										<div class="layui-tab">
											<ul class="layui-tab-title">
												<li class="layui-this">待审核</li>
												<li>审核通过</li>
												<li>审核未通过</li>
											</ul>
											<div class="layui-tab-content">
												<div class="layui-tab-item layui-show">
													<div class="layui-field-box layui-form">
														<table class="layui-table admin-table">
															<thead>
																<tr>
																	<th style="width: 30px;"><input type="checkbox" lay-filter="allselector" lay-skin="primary"></th>
																	<th>编号</th>
																	<th>用户库编号</th>
																	<th>车牌号码</th>
																	<th>车辆照片</th>
																	<th>行驶证照片</th>
																	<th>时间</th>
																	<th>状态</th>
																	<th>操作</th>
																	<th>备注</th>
																	<th>操作人</th>
																</tr>
															</thead>
															<tbody id="content">
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td>01245632</td>
																	<td>苏C25891</td>
																	<td><img src="" alt="" /></td>
																	<td><img src="" alt="" /></td>
																	<td>2017-03-02 </td>
																	<td>待审核</td>
																	<td>
																		<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini tongyi">通过</a>
																		<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-danger layui-btn-mini butongyi">否决</a>
																	</td>
																	<td>
																		<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-primary layui-btn-mini addbeizhu">添加备注</a>
																	</td>
																	<td></td>
																</tr>
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td>01245632</td>
																	<td>苏C25891</td>
																	<td><img src="" alt="" /></td>
																	<td><img src="" alt="" /></td>
																	<td>2017-03-02 </td>
																	<td>待审核</td>
																	<td>
																		<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini tongyi">通过</a>
																		<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-danger layui-btn-mini butongyi">否决</a>
																	</td>
																	<td>
																		<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-primary layui-btn-mini addbeizhu">添加备注</a>
																	</td>
																	<td></td>
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
																	<th>用户库编号</th>
																	<th>车牌号码</th>
																	<th>车辆照片</th>
																	<th>行驶证照片</th>
																	<th>时间</th>
																	<th>状态</th>
																	<th>操作</th>
																	<th>备注</th>
																	<th>操作人</th>
																</tr>
															</thead>
															<tbody id="Tbody1">
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td>01245632</td>
																	<td>苏C58778</td>
																	<td><img src="../../img/huo(3).jpg" alt="" /></td>
																	<td><img src="" alt="" /></td>
																	<td>2017-03-02 </td>
																	<td>已审核</td>
																	<td>通过</td>
																	<td>
																		<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-normal layui-btn-mini chakanbeizhu">查看备注</a><p class="beizhu" style="display: none;">我是备注信息，你看看吧</p>
																	</td>
																	<td>李花花</td>
																</tr>
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td>01245632</td>
																	<td>苏C58778</td>
																	<td><img src="../../img/huo(3).jpg" alt="" /></td>
																	<td><img src="" alt="" /></td>
																	<td>2017-03-02 </td>
																	<td>已审核</td>
																	<td>通过</td>
																	<td>
																		<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-normal layui-btn-mini chakanbeizhu">查看备注</a><p class="beizhu" style="display: none;">我是备注信息，你看看吧</p>
																	</td>
																	<td>李花花</td>
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
																	<th>用户库编号</th>
																	<th>车牌号码</th>
																	<th>车辆照片</th>
																	<th>行驶证照片</th>
																	<th>时间</th>
																	<th>状态</th>
																	<th>操作</th>
																	<th>备注</th>
																	<th>操作人</th>
																</tr>
															</thead>
															<tbody id="Tbody2">
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td>01245632</td>
																	<td>苏C58778</td>
																	<td><img src="../../img/huo(3).jpg" alt="" /></td>
																	<td><img src="" alt="" /></td>
																	<td>2017-03-02 </td>
																	<td>已审核</td>
																	<td>否决</td>
																	<td>
																		<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-normal layui-btn-mini chakanbeizhu">查看备注</a><p class="beizhu" style="display: none;">我是备注信息，你看看吧</p>
																	</td>
																	<td>李花花</td>
																</tr>
																
																<tr>
																	<td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
																	<td>1</td>
																	<td>01245632</td>
																	<td>苏C58778</td>
																	<td><img src="../../img/huo(3).jpg" alt="" /></td>
																	<td><img src="" alt="" /></td>
																	<td>2017-03-02 </td>
																	<td>已审核</td>
																	<td>否决</td>
																	<td>
																		<a href="javascript:;" data-opt="edit" class="layui-btn  layui-btn-normal layui-btn-mini chakanbeizhu">查看备注</a><p class="beizhu" style="display: none;">我是备注信息，你看看吧撒地方的萨菲撒地方山东发送发生大幅阿萨德飞撒地方阿斯达</p>
																	</td>
																	<td>李花花</td>
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
			    layui.use(['form', 'laypage', 'layer', "laydate", 'element'], function () {
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
			        form.on('checkbox(allselector)', function (data) {
			            var child = $(data.elem).parents('table').find('tbody input[type="checkbox"]');
			            child.each(function (index, item) {
			                item.checked = data.elem.checked;
			            });
			            form.render('checkbox');
			        });
			        //搜索
			        $('#search').on('click', function () {
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

			        //	添加备注
			        var bjBoxIndex = -1;
			        $(".addbeizhu").on('click', function () {
			            if (bjBoxIndex !== -1) { return; }
			            bjBoxIndex = layer.open({
			                type: 1,
			                title: '添加备注',
			                content: $("#tanchuang"),
			                btn: ['保存', '取消'],
			                shade: [0.6, '#393D49'],
			                offset: ['200px', '30%'],
			                area: ['550px', '250px'],
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

			        $("td img").on('click', function () {
			            if (bjBoxIndex !== -1) { return; }
			            var src = $(this).attr("src");

			            bjBoxIndex = layer.open({
			                type: 1,
			                title: '大图',
			                content: $("#tanchuang_img"),
			                shade: [0.6, '#393D49'],
			                offset: ['200px', '30%'],
			                area: ['650px', '500px'],
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
			                    $("#tanchuang_img").find("img").attr("src", src);
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
			        $(".chakanbeizhu").on('click', function () {
			            if (bjBoxIndex !== -1) { return; }
			            var str = $(this).next(".beizhu").html();
			            bjBoxIndex = layer.open({
			                type: 1,
			                title: '大图',
			                content: $("#tanchuang_beizhu"),
			                shade: [0.6, '#393D49'],
			                offset: ['200px', '30%'],
			                area: ['650px', '300px'],
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
			                    $("#tanchuang_beizhu").find("p").html(str);
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

			<!--添加备注-->
			<div style="display:none;margin: 15px;" id="tanchuang">
				<div class="layui-form">
					<div class="layui-form-item layui-form-text">
						<textarea placeholder="请输入内容" class="layui-textarea"></textarea>
					</div>
					<button lay-filter="edit" lay-submit style="display: none;"></button>
				</div>
			</div>
			<div style="display:none;margin: 15px;" id="tanchuang_beizhu">
				<div class="layui-form">
					<div class="layui-form-item layui-form-text">
						<p class="beizhu">哇哈哈哈哈！看我的动感光波</p>
					</div>
					<button lay-filter="edit" lay-submit style="display: none;"></button>
				</div>
			</div>
			
			<div style="display:none;margin: 15px;" id="tanchuang_img">
				<div class="layui-form">
					<div class="layui-form-item layui-form-text">
						<img src="" alt="" width="620"  />
					</div>
					<button lay-filter="edit" lay-submit style="display: none;"></button>
				</div>
			</div>
		</form>
	</body>

</html>