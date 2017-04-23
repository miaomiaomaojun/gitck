<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="office_Default" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>后台管理主页</title>
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
    <link rel="stylesheet" href="/office/css/pikaday.css">
    <link rel="stylesheet" href="/office/css/officehomepage.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="layui-layout layui-layout-admin" style="border-bottom: solid 5px #00c1de;">
            <uc1:top runat="server" ID="top" />
            <uc1:left_link runat="server" ID="left_link" />
			<!--右边开始-->
			<div class="layui-body" style="bottom:40px;border-left: solid 2px #00c1de;" id="admin-body">
				<div class="layui-tab admin-nav-card layui-tab-brief" lay-filter="admin-tab">
					<ul class="layui-tab-title">
						<li class="layui-this">
							<i class="fa fa-dashboard" aria-hidden="true"></i>
							<cite>主页</cite>
						</li>
					</ul>
					<div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0;background: #eee;">
						<div class="layui-tab-item layui-show">
					<!--内容-->
							<div class="homepage">
								<div class="notice_contain">
									<p>公告&nbsp;:</p>
									<div id="notice" onmouseover="clearInterval(timer)" onmouseout="timer=setInterval(mar,100)">
										<div id="notice1">
											<ul>
												<li><span class="time">[2017-01-25]</span><span class="gonggao">這是第一條公告</span></li>
												<li><span class="time">[2017-01-26]</span><span class="gonggao">這是第二條公告</span></li>
												<li><span class="time">[2017-01-27]</span><span class="gonggao">這是第三條公告</span></li>
												<li><span class="time">[2017-01-28]</span><span class="gonggao">這是第四條公告</span></li>
												<li><span class="time">[2017-01-29]</span><span class="gonggao">這是第五條公告</span></li>
											</ul>
										</div>
										<div id="notice2"></div>
									</div>
								</div>
								<div style="clear: both;"></div>
								<div class="watch">
									<div id="datepicker"></div>
								</div>
								<div class="news">
									<div class="news_table_title">
										<p>最新公告详情&nbsp;:</p>
									</div>
									<p class="news_title">通&nbsp;知&nbsp;:</p>
									<p class="news_contains">从前有座山，山上有座庙，庙里有个小和尚，我是通知知我是通知我是通知我是从前有座山，山上有座庙，庙里有个小和尚，我是通知知从前有座山，山上有座庙，庙里有个小和尚，我是通知知从前有座山，山上有座庙，庙里有个小和尚，我是通知知从前有座山，山上有座庙，庙里有个小和尚，我是通知知</p>
									<div style="clear: both;"></div>
								</div>
								<div class="message">
									<div class="news_table_title">
										<p>新闻动态&nbsp;:</p>
									</div>
									<ul class="news_list">
										<li>
											<a href="#">
												<p class="title"> 同城天下第一届招商同城天下第一届招商会圆满成功会圆满成功 现场气氛热烈</p>
												<p class="neirong">同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一</p>
												<p class="time">2017-03-12</p>
											</a>
										</li>
										<li>
											<a href="#">
												<p class="title"> 同城天下第一届招商同城天下第一届招商会圆满成功会圆满成功 现场气氛热烈</p>
												<p class="neirong">同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一</p>
												<p class="time">2017-03-12</p>
											</a>
										</li>
										<li>
											<a href="#">
												<p class="title"> 同城天下第一届招商同城天下第一届招商会圆满成功会圆满成功 现场气氛热烈</p>
												<p class="neirong">同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一</p>
												<p class="time">2017-03-12</p>
											</a>
										</li>
										<li>
											<a href="#">
												<p class="title"> 同城天下第一届招商同城天下第一届招商会圆满成功会圆满成功 现场气氛热烈</p>
												<p class="neirong">同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一</p>
												<p class="time">2017-03-12</p>
											</a>
										</li>
										<li>
											<a href="#">
												<p class="title"> 同城天下第一届招商同城天下第一届招商会圆满成功会圆满成功 现场气氛热烈</p>
												<p class="neirong">同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一同城天下第一届招商会圆满成功同城天下第一</p>
												<p class="time">2017-03-12</p>
											</a>
										</li>
									</ul>
									<div class="get_more">
										<a href="/office/pages/news.aspx">更多 <span>&nbsp;</span></a>
									</div>
								</div>
								<div class="x_box">
									<ul>
										<li>
											<a href="">
												<div class="photo">
													<img src="/office/images/photo.png"/>
												</div>
												<div class="divr">
													<p class="divr_title">同城天下李小朋：关于我们的故事2016</p>
													<p class="divr_contain">首先是来自同城天下CEO李小朋的一封发给员工的内部邮件各位同城天下同仁首先是来自同城天下CEO李小朋的一封发给员工的内部邮件各位同城天下同仁首先是来自同城天下CEO李小朋的一封发给员工的内部邮件各位同城天下同仁，首先祝大家儿童节快乐！这是同城天下500天来最艰难的一次选择、变革！ 因为这不是一次我们看 ...</p>
												</div>
											</a>
										</li>
										<li>
											<a href="">
												<div class="photo">
													<img src="/office/images/photo.png"/>
												</div>
												<div class="divr">
													<p class="divr_title">同城天下李小朋：关于我们的故事2016</p>
													<p class="divr_contain">首先是来自同城天下CEO李小朋的一封发给员工的内部邮件各位同城天下同仁首先是来自同城天下CEO李小朋的一封发给员工的内部邮件各位同城天下同仁首先是来自同城天下CEO李小朋的一封发给员工的内部邮件各位同城天下同仁，首先祝大家儿童节快乐！这是同城天下500天来最艰难的一次选择、变革！ 因为这不是一次我们看 ...</p>
												</div>
											</a>

										</li>
										<li id="boxul" class="bor_r0">
											<a href="">
												<div class="photo">
													<img src="/office/images/photo.png"/>
												</div>
												<div class="divr">
													<p class="divr_title">同城天下李小朋：关于我们的故事2016</p>
													<p class="divr_contain">首先是来自同城天下CEO李小朋的一封发给员工的内部邮件各位同城天下同仁首先是来自同城天下CEO李小朋的一封发给员工的内部邮件各位同城天下同仁首先是来自同城天下CEO李小朋的一封发给员工的内部邮件各位同城天下同仁，首先祝大家儿童节快乐！这是同城天下500天来最艰难的一次选择、变革！ 因为这不是一次我们看 ...</p>
												</div>
											</a>
										</li>
										<div style="clear: both;height: 30px;"></div>
									</ul>
									<div class="get_more">
										<a href="">更多 <span>&nbsp;</span></a>
									</div>
								</div>
								<div class="news_table">
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
										<a href="/office/pages/notice.aspx">更多 <span>&nbsp;</span></a>
									</div>
								</div>
							</div>

						</div>
					</div>
				</div>
			</div>
			<!--右边结束-->
			<!--底部页脚-->
			<div class="layui-footer footer footer-demo" id="admin-footer">
				<div class="layui-main">
					<p>
						2017 &copy;徐州掌汇网络科技有限公司 zhanghuitongcheng.com 苏ICP备15009587号-2
					</p>
				</div>
			</div>
			<div class="site-tree-mobile layui-hide">
				<i class="layui-icon">&#xe602;</i>
			</div>
			<div class="site-mobile-shade"></div>

		</div>
        <script type="text/javascript" src="/office/js/jquery-1.11.0.js"></script>
        <script type="text/javascript" src="/office/plugins/layui/layui.js"></script>
		<script type="text/javascript" src="/office/js/index.js"></script>
		<script type="text/javascript" src="/office/js/pikaday.js"></script>
		<script type="text/javascript" src="/office/js/pikaday.jquery.js"></script>
		<script type="text/javascript" src="/office/js/homepage.js"></script>
    </form>
</body>
</html>
