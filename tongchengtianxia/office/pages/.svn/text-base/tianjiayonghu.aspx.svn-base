<%@ Page Language="VB" AutoEventWireup="false" CodeFile="tianjiayonghu.aspx.vb" Inherits="office_pages_tianjiayonghu" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>添加用户</title>
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
								<cite>添加用户</cite>
							</li>
						</ul>
						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0; background: #fff;">
							<div class="layui-tab-item layui-show">
								<!--内容-->
								<div id="nav_name" name="添加用户">
									<div style="margin: 15px;">
										<div class="layui-form">
											<div class="layui-form-item">
												<label class="layui-form-label">用户名</label>
												<div class="layui-input-inline">
													<input type="text" name="username" lay-verify="phone" autocomplete="off" class="layui-input" value="15751000000">
												</div>
											</div>
											<!--数字-->
											<div class="layui-form-item">
												<label class="layui-form-label">密码</label>
												<div class="layui-input-inline">
													<input type="password" name="number" lay-verify="mima" autocomplete="off" class="layui-input">
												</div>
											</div>
                                            <%--提交--%>
                                            <div class="layui-form-item">
												<div class="layui-input-block">
													<button class="layui-btn" lay-submit="" lay-filter="demo1">立即提交</button>
													<button type="button" class="layui-btn layui-btn-primary" id="back">返回</button>
												</div>
											</div>
											
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
			   
			    layui.config({
			        base: '/office/js/'
			    });
			    layui.use(['form', 'laypage', 'layer', "laydate", 'upload'], function () {
			        var laypage = layui.laypage,
						$ = layui.jquery,
						layer = layui.layer, //获取当前窗口的layer对象
						layerTips = parent.layer === undefined ? layui.layer : parent.layer, //获取父窗口的layer对象
						form = layui.form();

			        $("#back").click(function () {
			            history.go(-1);
			        })

			        //添加nav选中项
			        var str = $("#nav_name").attr("name");
			        $("dd[title=" + str + "]").addClass("layui-this").parents("li").addClass("layui-nav-itemed");

			        //验证
			        form.verify({
			            mima: [/^.{5,15}$/, '请输入5到15个字符']
			        });


			        form.on('submit(demo1)', function (data) {
			            console.log(data.elem) //被执行事件的元素DOM对象，一般为button对象
			            console.log(data.form) //被执行提交的form对象，一般在存在form标签时才会返回
			            console.log(data.field) //当前容器的全部表单字段，名值对形式：{name: value}



			            return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。
			        });

			    });
			</script>

		</form>
	</body>

</html>