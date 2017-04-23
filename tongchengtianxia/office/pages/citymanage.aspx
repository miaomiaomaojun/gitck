<%@ Page Language="VB" AutoEventWireup="false" CodeFile="citymanage.aspx.vb" Inherits="office_pages_citymanage" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>城市管理</title>
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

				<!--右边开始-->
				<div class="layui-body" style="bottom: 0; border-left: solid 2px #00c1de;" id="admin-body">
					<div class="layui-tab admin-nav-card layui-tab-brief" lay-filter="admin-tab">
						<ul class="layui-tab-title">
							<li class="layui-this">
								<i class="fa fa-dashboard" aria-hidden="true"></i>
								<cite>城市管理</cite>
							</li>
						</ul>
						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0; background: #fff;">
							<div class="layui-tab-item layui-show">
								<!--内容-->
								<div id="nav_name" name="城市管理">
									<fieldset class="layui-elem-field" style="width: 35%; float: left;">
										<legend>城市列表</legend>
										<div class="layui-field-box layui-form">
											<div class="layui-elem-quote">
												<a href="javascript:;" class="layui-btn layui-btn-small" id="addcity">
													<i class="layui-icon">&#xe608;</i> 添加城市
												</a>
												<div class="admin-table-page">
													<div id="paged" class="page">
													</div>
												</div>
											</div>
											<table class="layui-table admin-table">
												<thead>
													<tr>
														<th>编号</th>
														<th>城市</th>
														<th>拼音</th>
														<th>热门</th>
														<th>操作</th>
													</tr>
												</thead>
												<tbody id="content">
													<tr>
														<td class="cityid">1</td>
														<td class="cityname">呼和浩特</td>
														<td class="citypy">huhehaote</td>
														<td>是</td>
														<td>
															<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini bianji">编辑</a>
															<a href="javascript:;" data-id="1" data-opt="del" class="layui-btn layui-btn-danger layui-btn-mini del">删除</a>
															<a href="javascript:;" class="layui-btn layui-btn-normal layui-btn-mini chakanqx">查看区县</a>
														</td>
													</tr>
													<tr>
														<td class="cityid">2</td>
														<td class="cityname">浩特</td>
														<td class="citypy">huhehaote</td>
														<td>否</td>
														<td>
															<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini bianji">编辑</a>
															<a href="javascript:;" data-id="1" data-opt="del" class="layui-btn layui-btn-danger layui-btn-mini del">删除</a>
															<a href="javascript:;" class="layui-btn layui-btn-normal layui-btn-mini chakanqx">查看区县</a>
														</td>
													</tr>
												</tbody>
											</table>
											<!--分页器-->
											<div id="fy_1"></div>
										</div>
									</fieldset>
									<fieldset class="layui-elem-field" style="width: 31%; float: left; display:none; " id="quxian">
										<legend>区县列表</legend>
										<div class="layui-field-box layui-form">
											<div class="layui-elem-quote">
												<div class="layui-input-inline" id="qxct">呼和浩特</div>
												<a href="javascript:;" class="layui-btn layui-btn-small" id="addqx">
													<i class="layui-icon">&#xe608;</i>添加区县
												</a>
												<div class="admin-table-page">
													<div id="Div1" class="page">
													</div>
												</div>
											</div>
											<table class="layui-table admin-table">
												<thead>
													<tr>
														<th>城市编号</th>
														<th>区县</th>
														<th>操作</th>
													</tr>
												</thead>
												<tbody id="Tbody1">
													<tr>
														<th>1</th>
														<td class="qxname">赛罕区</td>
														<td>
															<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini bianjiqx">编辑</a>
															<a href="javascript:;" data-id="1" data-opt="del" class="layui-btn layui-btn-danger layui-btn-mini del">删除</a>
															<a href="javascript:;" data-id="1" data-opt="del" class="layui-btn layui-btn-normal layui-btn-mini chakansq">查看商圈</a>
														</td>
													</tr>
												</tbody>
											</table>
											<!--分页器-->
											<div id="fy_2"></div>
										</div>
									</fieldset>
									<fieldset class="layui-elem-field" style="width: 31%; float: left;  display:none; " id="shangquan">
										<legend>商圈列表</legend>
										<div class="layui-field-box layui-form">
											<div class="layui-elem-quote">
												<div class="layui-input-inline" id="sqctqy">
													<span>呼和浩特</span>-<i>赛罕区</i>
												</div>
												<a href="javascript:;" class="layui-btn layui-btn-small" id="addsq">
													<i class="layui-icon">&#xe608;</i> 添加商圈
												</a>
												<div class="admin-table-page">
													<div id="Div2" class="page">
													</div>
												</div>
											</div>
											<table class="layui-table admin-table">
												<thead>
													<tr>
														<th>区县编号</th>
														<th>商圈</th>
														<th>操作</th>
													</tr>
												</thead>
												<tbody id="Tbody2">
													<tr>
														<th>1</th>
														<th class="sqname">大学城摩尔城敦煌大厦</th>
														<td>
															<a href="javascript:;" data-opt="edit" class="layui-btn layui-btn-mini bianjisq">编辑</a>
															<a href="javascript:;" data-id="1" data-opt="del" class="layui-btn layui-btn-danger layui-btn-mini del">删除</a>
														</td>
													</tr>
												</tbody>
											</table>
											<!--分页器-->
											<div id="fy_3"></div>
										</div>
									</fieldset>

								</div>

							</div>
						</div>
					</div>
				</div>

				<uc1:bottom runat="server" ID="bottom" />

			</div>

			<%--添加城市--%>

			<div style="display:none;margin: 15px;" id="tanchuang">
				<div class="layui-form">
					<!--数字-->
					<div class="layui-form-item">
						<label class="layui-form-label">城市</label>
						<div class="layui-input-inline">
							<input type="text" name="city" lay-verify="city" placeholder="请输入城市名" autocomplete="off" class="layui-input">
						</div>
					</div>
					<!--数字-->
					<div class="layui-form-item">
						<label class="layui-form-label">拼音</label>
						<div class="layui-input-inline">
							<input type="text" name="pinyin" lay-verify="pinyin" placeholder="请输入拼音" autocomplete="off" class="layui-input">
						</div>
					</div>
                    <div class="layui-form-item">
						<label class="layui-form-label">首字母</label>
						<div class="layui-input-inline">
							<input type="text" name="shouzimu" lay-verify="shouzimu" placeholder="请输入大写拼音首字母" autocomplete="off" class="layui-input">
						</div>
					</div>
					<div class="layui-form-item">
						<label class="layui-form-label">是否热门</label>
						<div class="layui-input-block">
					    	<input type="radio" name="remen" value="1" title="是" checked>
					   		<input type="radio" name="remen" value="0" title="否">
					    </div>
					</div>
					
					
					<button lay-filter="edit" lay-submit style="display: none;"></button>
				</div>
			</div>

			<%--添加区县--%>
			<div style="display:none;margin: 15px;" id="tanchuang_qx">
				<div class="layui-form">
					<!--数字-->
					<div class="layui-form-item">
						<label class="layui-form-label">城市</label>
						<div class="layui-input-inline">
							<input type="text" name="qxcity" autocomplete="off" class="layui-input" disabled>
						</div>
					</div>
					<!--数字-->
					<div class="layui-form-item">
						<label class="layui-form-label">区县</label>
						<div class="layui-input-inline">
							<input type="text" name="quxian" lay-verify="quxian" placeholder="请输入" autocomplete="off" class="layui-input">
						</div>
					</div>
					<button lay-filter="edit1" lay-submit style="display: none;"></button>
				</div>
			</div>

			<%--添加商圈--%>
			<div style="display:none;margin: 15px;" id="tanchuang_sq">
				<div class="layui-form">
					<!--数字-->
					<div class="layui-form-item">
						<label class="layui-form-label">城市</label>
						<div class="layui-input-inline">
							<input type="text" name="ctname" autocomplete="off" class="layui-input" disabled>
						</div>
					</div>
					<div class="layui-form-item">
						<label class="layui-form-label">区县</label>
						<div class="layui-input-inline">
							<input type="text" name="qyname" autocomplete="off" class="layui-input" disabled>
						</div>
					</div>
					<!--数字-->
					<div class="layui-form-item">
						<label class="layui-form-label">商圈</label>
						<div class="layui-input-inline">
							<input type="text" name="sqname" lay-verify="shangquan" placeholder="请输入商圈" autocomplete="off" class="layui-input">
						</div>
					</div>
					<button lay-filter="edit2" lay-submit style="display: none;"></button>
				</div>
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
						
						//验证
					form.verify({
						city: [/^[\u4e00-\u9fa5]{2,20}$/,'请输入中文城市名'],
						pinyin: [/^[a-zA-Z]{2,100}$/, '请输入拼音'],
						shouzimu: [/^[A-Z]$/, '请输入大写首字母'],
						quxian:[/^[\u4e00-\u9fa5]{2,20}$/,'请输入区县'],
						shangquan:[/^[\u4e00-\u9fa5]{2,20}$/,'请输入商圈']
					});

						
						
					//添加nav选中项
					var str = $("#nav_name").attr("name");
					$("dd[title=" + str + "]").addClass("layui-this").parents("li").addClass("layui-nav-itemed");

					

					//查看区县
					$(".chakanqx").click(function() {
						$("#shangquan").hide();
						$("#quxian").show();
						var $this = $(this),
							$tr = $this.parents("tr"),
							cityname = $tr.children(".cityname").html(),
							cityid = $tr.children(".cityid").html(),
							citypy = $tr.children(".citypy").html();
						$("#qxct").html(cityname);
						//这里需要获取当前城市的区县

					})
					//查看商圈
					$(".chakansq").click(function() {
						$("#shangquan").show();
						var $this = $(this),
							$tr = $this.parents("tr"),
							qxname = $tr.children(".qxname").html();
						cityname = $.trim($this.parents(".layui-form").find("#qxct").html());

						$("#sqctqy span").html(cityname);
						$("#sqctqy i").html(qxname);
						//这里需要获取当前城市区县的商圈

					})

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
					laypage({
						cont: 'fy_3',
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
					//添加城市
					var addBoxIndex = -1;
					$('#addcity').on('click', function() {
						if(addBoxIndex !== -1) {
							return;
						}
						addBoxIndex = layer.open({
							type: 1,
							title: '添加城市',
							content: $("#tanchuang"),
							btn: ['保存', '取消'],
							shade: [0.6, '#393D49'],
							offset: ['100px', '30%'],
							area: ['550px', '300px'],
							zIndex: 999,
							maxmin: true,
							yes: function(index) {
								//触发表单的提交事件
								$('div.layui-form').find('button[lay-filter=edit]').click();
							},
							full: function(elem) {
								var win = window.top === window.self ? window : parent.window;
								$(win).on('resize', function() {
									var $this = $(this);
									elem.width($this.width()).height($this.height()).css({
										top: 0,
										left: 0
									});
									elem.children('div.layui-layer-content').height($this.height() - 95);
								});
							},
							success: function(layero, index) {
								//弹出窗口成功后渲染表单
								var form = layui.form();
								form.render();
								form.on('submit(edit)', function(data) {
									console.log(data.elem) //被执行事件的元素DOM对象，一般为button对象
									console.log(data.form) //被执行提交的form对象，一般在存在form标签时才会返回
									console.log(data.field) //当前容器的全部表单字段，名值对形式：{name: value}
									// 这里是发送命令，更改城市名称
									layer.close(index);
									return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。									
								});
							},
							end: function() {
								addBoxIndex = -1;
							}
						});

					});
					//添加区县
					var addBoxIndex1 = -1;
					$('#addqx').on('click', function() {
						if(addBoxIndex1 !== -1) {
							return;
						}
						var qxct = $(this).prev("#qxct").html();

						addBoxIndex1 = layer.open({
							type: 1,
							title: '添加区县',
							content: $("#tanchuang_qx"),
							btn: ['保存', '取消'],
							shade: [0.6, '#393D49'],
							offset: ['100px', '30%'],
							area: ['550px', '250px'],
							zIndex: 999,
							maxmin: true,
							yes: function(index) {
								//触发表单的提交事件
								$('div.layui-form').find('button[lay-filter=edit1]').click();
							},
							full: function(elem) {
								var win = window.top === window.self ? window : parent.window;
								$(win).on('resize', function() {
									var $this = $(this);
									elem.width($this.width()).height($this.height()).css({
										top: 0,
										left: 0
									});
									elem.children('div.layui-layer-content').height($this.height() - 95);
								});
							},
							success: function(layero, index) {
								//弹出窗口成功后渲染表单
								var form = layui.form();
								form.render();
								$("#tanchuang_qx").find("input[name='qxcity']").val(qxct);
								form.on('submit(edit1)', function(data) {
									console.log(data.elem) //被执行事件的元素DOM对象，一般为button对象
									console.log(data.form) //被执行提交的form对象，一般在存在form标签时才会返回
									console.log(data.field) //当前容器的全部表单字段，名值对形式：{name: value}
									// 这里是发送命令，更改城市名称

									layer.close(index);
									return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。									
								});
							},
							end: function() {
								addBoxIndex1 = -1;
							}
						});

					});
					//添加商圈
					var addBoxIndex2 = -1;
					$('#addsq').on('click', function() {
						if(addBoxIndex2 !== -1) {
							return;
						}
						var $this = $(this),
							$tr = $this.parents("tr"),
							cityname = $.trim($("#sqctqy span").html()),
							qxname = $.trim($("#sqctqy i").html());

						addBoxIndex2 = layer.open({
							type: 1,
							title: '添加商圈',
							content: $("#tanchuang_sq"),
							btn: ['保存', '取消'],
							shade: [0.6, '#393D49'],
							offset: ['100px', '30%'],
							area: ['550px', '300px'],
							zIndex: 999,
							maxmin: true,
							yes: function(index) {
								//触发表单的提交事件
								$('div.layui-form').find('button[lay-filter=edit2]').click();
							},
							full: function(elem) {
								var win = window.top === window.self ? window : parent.window;
								$(win).on('resize', function() {
									var $this = $(this);
									elem.width($this.width()).height($this.height()).css({
										top: 0,
										left: 0
									});
									elem.children('div.layui-layer-content').height($this.height() - 95);
								});
							},
							success: function(layero, index) {
								//弹出窗口成功后渲染表单
								var form = layui.form();
								form.render();
								$("#tanchuang_sq").find("input[name='ctname']").val(cityname);
								$("#tanchuang_sq").find("input[name='qyname']").val(qxname);
								$("#tanchuang_sq").find("input[name='sqname']").val("");
								form.on('submit(edit2)', function(data) {
									console.log(data.elem) //被执行事件的元素DOM对象，一般为button对象
									console.log(data.form) //被执行提交的form对象，一般在存在form标签时才会返回
									console.log(data.field) //当前容器的全部表单字段，名值对形式：{name: value}
									// 这里是发送命令，更改城市名称

									layer.close(index);
									return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。									
								});
							},
							end: function() {
								addBoxIndex2 = -1;
							}
						});

					});

					/*删除*/
					$(".del").click(function() {
						$(this).parents("tr").remove();
					});
					//编辑城市
					var bjBoxIndex = -1;
					$(".bianji").on('click', function() {
						if(bjBoxIndex !== -1) { return; }
						//本表单通过ajax加载 --以模板的形式，当然你也可以直接写在页面上读取
						var $this = $(this),
							$tr = $this.parents("tr"),
							cityname = $.trim($tr.children(".cityname").html()) ,
							cityid =$.trim($tr.children(".cityid").html()),
							citypy =$.trim($tr.children(".citypy").html()),
						    cityshou = citypy.substring(0, 1).toUpperCase();

						bjBoxIndex = layer.open({
							type: 1,
							title: '编辑城市',
							content: $("#tanchuang"),
							btn: ['保存', '取消'],
							shade: [0.6, '#393D49'],
							offset: ['100px', '30%'],
							area: ['550px', '300px'],
							zIndex: 999,
							maxmin: true,
							yes: function(index) {
								//触发表单的提交事件
								$('div.layui-form').find('button[lay-filter=edit]').click();
							},
							full: function(elem) {
								var win = window.top === window.self ? window : parent.window;
								$(win).on('resize', function() {
									var $this = $(this);
									elem.width($this.width()).height($this.height()).css({
										top: 0,
										left: 0
									});
									elem.children('div.layui-layer-content').height($this.height() - 95);
								});
							},
							success: function(layero, index) {

								//弹出窗口成功后渲染表单
								var form = layui.form();
								form.render();
								$("#tanchuang").find("input[name='city']").val(cityname);
								$("#tanchuang").find("input[name='pinyin']").val(citypy);
								$("#tanchuang").find("input[name='shouzimu']").val(cityshou);
								form.on('submit(edit)', function(data) {
									console.log(data.elem) //被执行事件的元素DOM对象，一般为button对象
									console.log(data.form) //被执行提交的form对象，一般在存在form标签时才会返回
									console.log(data.field) //当前容器的全部表单字段，名值对形式：{name: value}
									// 这里是发送命令，更改城市名称

									layer.close(index);
									return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。									
								});
							},
							end: function() {
								bjBoxIndex = -1;
							}
						});
					});
					//编辑区县
					var bjBoxIndex1 = -1;
					$('.bianjiqx').on('click', function() {
						if(bjBoxIndex1 !== -1) {
							return;
						}
						var $this = $(this),
							$tr = $this.parents("tr"),
							cityname = $.trim($this.parents(".layui-form").find("#qxct").html()),
							//  cityid = $tr.children(".cityid").html(),  需要的时候可以改成城市的ID
							qxname = $tr.children(".qxname").html();

						bjBoxIndex1 = layer.open({
							type: 1,
							title: '编辑区县',
							content: $("#tanchuang_qx"),
							btn: ['保存', '取消'],
							shade: [0.6, '#393D49'],
							offset: ['100px', '30%'],
							area: ['550px', '250px'],
							zIndex: 999,
							maxmin: true,
							yes: function(index) {
								//触发表单的提交事件
								$('div.layui-form').find('button[lay-filter=edit1]').click();
							},
							full: function(elem) {
								var win = window.top === window.self ? window : parent.window;
								$(win).on('resize', function() {
									var $this = $(this);
									elem.width($this.width()).height($this.height()).css({
										top: 0,
										left: 0
									});
									elem.children('div.layui-layer-content').height($this.height() - 95);
								});
							},
							success: function(layero, index) {
								//弹出窗口成功后渲染表单       
								var form = layui.form();
								form.render();
								$("#tanchuang_qx").find("input[name='qxcity']").val(cityname);
								$("#tanchuang_qx").find("input[name='quxian']").val(qxname);
								form.on('submit(edit1)', function(data) {
									console.log(data.elem) //被执行事件的元素DOM对象，一般为button对象
									console.log(data.form) //被执行提交的form对象，一般在存在form标签时才会返回
									console.log(data.field) //当前容器的全部表单字段，名值对形式：{name: value}
									// 这里是发送命令，更改城市名称

									layer.close(index);
									return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。									
								});
							},
							end: function() {
								bjBoxIndex1 = -1;
							}
						});

					});
					//编辑商圈
					var bjBoxIndex2 = -1;
					$('.bianjisq').on('click', function() {
						if(bjBoxIndex2 !== -1) {
							return;
						}
						var $this = $(this),
							$tr = $this.parents("tr"),
							cityname = $.trim($("#sqctqy span").html()),
							qxname = $.trim($("#sqctqy i").html()),
							sqname = $.trim($tr.children(".sqname").html());
						console.log(cityname);
						//  cityid = $tr.children(".cityid").html(),  需要的时候可以改成城市的ID
						bjBoxIndex2 = layer.open({
							type: 1,
							title: '编辑商圈',
							content: $("#tanchuang_sq"),
							btn: ['保存', '取消'],
							shade: [0.6, '#393D49'],
							offset: ['100px', '30%'],
							area: ['550px', '300px'],
							zIndex: 999,
							maxmin: true,
							yes: function(index) {
								//触发表单的提交事件
								$('div.layui-form').find('button[lay-filter=edit2]').click();
							},
							full: function(elem) {
								var win = window.top === window.self ? window : parent.window;
								$(win).on('resize', function() {
									var $this = $(this);
									elem.width($this.width()).height($this.height()).css({
										top: 0,
										left: 0
									});
									elem.children('div.layui-layer-content').height($this.height() - 95);
								});
							},
							success: function(layero, index) {
								//弹出窗口成功后渲染表单
								var form = layui.form();
								form.render();
								console.log(cityname);
								$("#tanchuang_sq").find("input[name='ctname']").val(cityname);
								$("#tanchuang_sq").find("input[name='qyname']").val(qxname);
								$("#tanchuang_sq").find("input[name='sqname']").val(sqname);
								form.on('submit(edit2)', function(data) {
									console.log(data.elem) //被执行事件的元素DOM对象，一般为button对象
									console.log(data.form) //被执行提交的form对象，一般在存在form标签时才会返回
									console.log(data.field) //当前容器的全部表单字段，名值对形式：{name: value}
									// 这里是发送命令，更改商圈名称

									layer.close(index);
									return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。									
								});
							},
							end: function() {
								bjBoxIndex2 = -1;
							}
						});

					});


					

				});
			</script>

		</form>
	</body>

</html>