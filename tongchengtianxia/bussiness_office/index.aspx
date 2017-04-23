<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="office_Default" %>

<%@ Register Src="~/bussiness_office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/bussiness_office/top.ascx" TagPrefix="uc1" TagName="top" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	<head runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<title>后台管理主页</title>
		<meta name="renderer" content="webkit">
		<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
		<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
		<meta name="apple-mobile-web-app-status-bar-style" content="black">
		<meta name="apple-mobile-web-app-capable" content="yes">
		<meta name="format-detection" content="telephone=no">
		<link rel="shortcut icon" href="/bussiness_office/images/favicon.ico" />
		<link rel="stylesheet" href="/bussiness_office/plugins/layui/css/layui.css" media="all" />
		<link rel="stylesheet" href="/bussiness_office/css/global.css" media="all">
		<link rel="stylesheet" href="/bussiness_office/plugins/font-awesome/css/font-awesome.min.css">
		<link rel="stylesheet" href="/bussiness_office/css/pikaday.css">
		<link rel="stylesheet" href="/bussiness_office/css/officehomepage.css" />
	</head>
	<style>
		
		/*.........*/
		
	</style>

	<body>
		<form id="form1" runat="server">
			<div class="layui-layout layui-layout-admin" style="border-bottom: solid 5px #00c1de;">
				<uc1:left_link runat="server" ID="left_link" />
				<uc1:top runat="server" ID="top" />
				<!--右边开始-->
				<div class="layui-body" id="admin-body">
					<!--内容-->
					<div class="person_message">
						<h4 class="shop_name">重庆小面</h4>
						<span class="rzxx">认证信息：</span><span class="answer">已提交认证</span><span class="answer_icon1"></span>
						<span class="pf">店铺状态：</span><span class="answer">正常营业</span><span class="answer_icon2"></span>
						<span class="pf">店铺评分：</span><span class="star"></span>
					</div>
					<div class="shop_column_fris">
						<div class="column_logo1">
							<div></div>
						</div>
						<p class="column_top">今日销售金额</p>
						<p class="column_bottom">￥520.8</p>
					</div>
					<div class="shop_column">
						<div class="column_logo2" style="float: left;">
							<div></div>
						</div>
						<p class="column_top">今日订单数</p>
						<p class="column_bottom" style="color: #56bce2;">100</p>
					</div>
					<div class="shop_column">
						<div class="column_logo3">
							<div></div>
						</div>
						<p class="column_top">在售商品</p>
						<p class="column_bottom" style="color: #fec400;">1400</p>
					</div>
					<div class="shop_column">
						<div class="column_logo4">
							<div></div>
						</div>
						<p class="column_top">全部订单</p>
						<p class="column_bottom" style="color: #6dc7be;">1200</p>
					</div>
					<div class="shop_column">
						<div class="column_logo5">
							<div></div>
						</div>
						<p class="column_top">账户资金</p>
						<p class="column_bottom" style="color: #b198da;">￥1520.8</p>
					</div>
					<div class="clear"></div>
					<div class="column_left">
						<table class="ddgl" cellspacing="0" cellpadding="2">
							<tr>
								<th colspan="2" class="ddgl-top">订单管理
									<p class="more">更多<i></i></p>
								</th>
							</tr>
							<tr style="border-bottom: 1px #DDDDDD solid;">
								<td>
									<p>待付款</p>
									<p>12条</p>
								</td>
								<td style="border-right: none;">
									<p>付款中</p>
									<p>12条</p>
								</td>
							</tr>
							<tr>
								<td>
									<p>已支付</p>
									<p>12条</p>
								</td>
								<td style="border-right: none;">
									<p>已退款</p>
									<p>12条</p>
								</td>
							</tr>
						</table>
					</div>
					<div class="column_right">
						<table class="zxdd" cellspacing="0" cellpadding="2">
							<thead>
								<tr>
									<th colspan="4" class="zxdd-top">最新的6条订单</th>
								</tr>
								<tr>
									<th>商品名</th>
									<th>订单号</th>
									<th>金额</th>
									<th>成交时间</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td>重庆小面12元套餐1份，免预约</td>
									<td>123456789987654321</td>
									<td>￥12</td>
									<td>2017-01-01 14:00</td>
								</tr>
								<tr>
									<td>重庆小面12元套餐1份，免预约</td>
									<td>123456789987654321</td>
									<td>￥12</td>
									<td>2017-01-01 14:00</td>
								</tr>
								<tr>
									<td>重庆小面12元套餐1份，免预约</td>
									<td>123456789987654321</td>
									<td>￥12</td>
									<td>2017-01-01 14:00</td>
								</tr>
								<tr>
									<td>重庆小面12元套餐1份，免预约</td>
									<td>123456789987654321</td>
									<td>￥12</td>
									<td>2017-01-01 14:00</td>
								</tr>
								<tr>
									<td>重庆小面12元套餐1份，免预约</td>
									<td>123456789987654321</td>
									<td>￥12</td>
									<td>2017-01-01 14:00</td>
								</tr>
								<tr>
									<td>重庆小面12元套餐1份，免预约</td>
									<td>123456789987654321</td>
									<td>￥12</td>
									<td>2017-01-01 14:00</td>
								</tr>

							</tbody>
						</table>
					</div>
					<div class="column_left" style="margin-top: 15px;">
						<table class="zxdd" cellspacing="0" cellpadding="2">
							<thead>
								<tr>
									<th colspan="3" class="zxdd-top">登录记录
										<p class="more">更多<i></i></p>
									</th>
								</tr>
								<tr>
									<th>时间</th>
									<th>IP地址</th>
									<th>登录地址</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td>2017-04-11 14：00，免预约</td>
									<td>192.168.1.1</td>
									<td>江苏徐州</td>
								</tr>
								<tr>
									<td>2017-04-11 14：00，免预约</td>
									<td>192.168.1.1</td>
									<td>江苏徐州</td>
								</tr>
								<tr>
									<td>2017-04-11 14：00，免预约</td>
									<td>192.168.1.1</td>
									<td>江苏徐州</td>
								</tr>
								<tr>
									<td>2017-04-11 14：00，免预约</td>
									<td>192.168.1.1</td>
									<td>江苏徐州</td>
								</tr>
							</tbody>
						</table>

					</div>
					<div class="column_right" style="margin-top: 15px;">
						<table class="gsdt" cellspacing="0" cellpadding="2">
							<thead>
								<tr>
									<th colspan="1" class="zxdd-top">公司动态
										<p class="more">更多<i></i></p>
									</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td>
										<p class="time">2016-01-16</p>
										<p class="notice">第二排测试内容超出显示省第二排测试省</p>
									</td>
								</tr>
								<tr>
									<td>
										<p class="time">2016-01-16</p>
										<p class="notice">第二排测试内容超出显示省第二排测试省</p>
									</td>
								</tr>
								<tr>
									<td>
										<p class="time">2016-01-16</p>
										<p class="notice">第二排测试内容超出显示省第二排测试省</p>
									</td>
								</tr>
								<tr>
									<td>
										<p class="time">2016-01-16</p>
										<p class="notice">第二排测试内容超出显示省第二排测试省</p>
									</td>
								</tr>
								<tr>
									<td>
										<p class="time">2016-01-16</p>
										<p class="notice">第二排测试内容超出显示省第二排测试省</p>
									</td>
								</tr>
								<tr>
									<td>
										<p class="time">2016-01-16</p>
										<p class="notice">第二排测试内容超出显示省第二排测试省</p>
									</td>
								</tr>
							</tbody>
						</table>

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

			
			
		</form>
	</body>

</html>