<%@ Page Language="VB" AutoEventWireup="false" CodeFile="noticedetail.aspx.vb" Inherits="office_pages_noticedetail" %>

<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>
<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head id="Head1" runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>通知公告</title>
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
		<link rel="stylesheet" href="/office/css/notice.css" />

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
								<cite>通知公告</cite>
							</li>
						</ul>
						<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0;background: #fff;">
							<div class="layui-tab-item layui-show">
								<!--内容-->
								<div id="nav_name" name="">
									<div class="body_right">
										<!--主页-->
										<div class="notice">

											<div class="notice_list">
												<div class="news_table_title">
													<p>通知公告&nbsp;:</p>
												</div>
												<ul class="news_table_list">
													<li>
														<a href="#">
															<p class="time">2016-01-16</p>
															<p>第二排测试内容超出显示省第二排测试内容超出显示省第二排测试内容超出显示省第二排测试内容超出显示省 第二排测试内容超出显示省</p>
														</a>
													</li>
													<li>
														<a href="#">
															<p class="time">2016-01-16</p>
															<p>第二排测试内容超出显示省第二排测试内容超出显示省第二排测试内容超出显示省第二排测试内容超出显示省 第二排测试内容超出显示省</p>
														</a>
													</li>
													<li>
														<a href="#">
															<p class="time">2016-01-16</p>
															<p>第二排测试内容超出显示省第二排测试内容超出显示省第二排测试内容超出显示省第二排测试内容超出显示省 第二排测试内容超出显示省</p>
														</a>
													</li>
													<li>
														<a href="#">
															<p class="time">2016-01-16</p>
															<p>第二排测试内容超出显示省第二排测试内容超出显示省第二排测试内容超出显示省第二排测试内容超出显示省 第二排测试内容超出显示省</p>
														</a>
													</li>
													<li>
														<a href="#">
															<p class="time">2016-01-16</p>
															<p>第二排测试内容超出显示省第二排测试内容超出显示省第二排测试内容超出显示省第二排测试内容超出显示省 第二排测试内容超出显示省</p>
														</a>
													</li>

													<li>
														<a href="#">
															<p class="time">2016-01-16</p>
															<p>第二排测试内容超出显示省第二排测试内容超出显第二排测试内容超出显示省第二排测试内容超出显示省第二排测试内容超出显示省第二排测试内容超出显示省示省第二排测试内容超出显示省第二排测试内容超出显示省</p>
														</a>
													</li>
												</ul>
												<div class="get_more">
													<a href="">更多 <span>&nbsp;</span></a>
												</div>
											</div>
										</div>
										<div class="notice_listmore">
											<div class="noticedetail">
												这里是编辑器
											</div>
											<p class="fanye">
												<a href=""><span class="pre">上一篇:</span><span class="pre">关于妇女节的放假通知</span></a>
												<a href=""><span class="next">关于妇女节的放假通知</span><span class="next">下一篇:</span>
												</a>

												<div class="holder"></div>
												<p class="page" style=""><span id="legend2"></span><span id="legend1"></span></p>
										</div>

									</div>

								</div>
							</div>
						</div>
					</div>
					
				</div>
                <uc1:bottom runat="server" ID="bottom" />
				<script type="text/javascript" src="/office/plugins/layui/layui.js"></script>
				<script type="text/javascript" src="/office/js/index.js"></script>
			</form>
	</body>

</html>
