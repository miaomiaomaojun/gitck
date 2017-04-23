<%@ Page Language="VB" AutoEventWireup="false" CodeFile="record.aspx.vb" Inherits="bussiness_office_record" %>

<%@ Register Src="~/bussiness_office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/bussiness_office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/bussiness_office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>管理验证</title>
    <meta name="renderer" content="webkit">
		<meta name="renderer" content="webkit">
		<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
		<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
		<meta name="apple-mobile-web-app-status-bar-style" content="black">
		<meta name="apple-mobile-web-app-capable" content="yes">
		<meta name="format-detection" content="telephone=no">
		<link rel="shortcut icon" href="/bussiness_office/images/favicon.ico" />
		<link rel="stylesheet" href="/bussiness_office/plugins/layui/css/layui.css" media="all" />
		<link rel="stylesheet" href="/bussiness_office/css/global.css" media="all">
    <link rel="stylesheet" href="/bussiness_office/css/laypage.css" media="all">
		<link rel="stylesheet" href="/bussiness_office/plugins/font-awesome/css/font-awesome.min.css">
    <link rel="stylesheet" href="/bussiness_office/css/record.css" />
    	<link rel="stylesheet" href="/bussiness_office/css/officehomepage.css" />
    	<style>
       	body {
			background: #f2f2f2;
		}
		
		.layui-form .layui-elem-field {
			min-height: 600px;
			position: relative;
		}
		
		.layui-form .layui-elem-field .form-title {
			height: 68px;
			width: 100%;
			background: #FFFFFF;
		}
		
		.layui-form .layui-elem-field .form-title p {
			line-height: 40px;
			padding: 0 5px 0 5px;
			font-size: 18px;
			color: #444444;
            float:left;
            border-bottom:3px #00c1de solid;
            margin-top:26px;
            margin-left:10px;
		}
		
		.layui-input,
		.layui-select,
		.layui-textarea {
			height: 28px;
		}
		
		.layui-btn-small {
			height: 28px;
		}
		
		.layui-btn-small i {
			padding: 3px 5px;
			font-size: 13px!important;
		}
		
		.layui-form-label {
			padding: 5px 10px;
			text-align: left;
			width: 70px;
		}
		
		.layui-form .layui-elem-field .fenyebox {
			height: 60px;
			position: absolute;
			bottom: 0px;
			background: #FFFFFF;
			width: 100%;
		}
		
		.layui-form .layui-elem-field .fenyebox .fy_1 {
			float: right;
			margin-right: 10px;
			margin-top: 5px;
		}
		
		.layui-input,
		.layui-textarea {
			line-height: 28px;
		}
	</style>
</head>
<body>
<form id="form1" runat="server">
     <div class="layui-layout layui-layout-admin">
        <uc1:top runat="server" ID="top" />
         <uc1:left_link runat="server" ID="left_link" />
             <div class="layui-body" style="bottom:40px;border-left: solid 2px #00c1de;min-width: 924px;background: #f2f2f2;" id="admin-body">

                 <div class="ind-box">
                      <div class="mslaf-omw"><div class="shop" title="验证记录">验证管理</div></div>
                        <div class="layui-form">
                          <table class="layui-table bord-now" lay-skin="line">
                                <colgroup>
                                    <col>
                                    <col width="280">
                                    <col>
                                </colgroup>
                                <thead>
                                    <tr>
                                        <th>
                                            <form action="#" method="post">
                                              消费券：<input type="search" name="search" class="ind-sear" value="">&nbsp;&nbsp;&nbsp;&nbsp;日期：<input type="text" class="swc-text" onclick="layui.laydate({ elem: this, istime: true, format: 'YYYY-MM-DD' })"><button type="submit" class="but-sear"><i class="layui-icon">&#xe615;</i>搜索</button>
                                            </form>
                                       </th>
                                        <th></th>
                                        <th></th>
                                    </tr> 
                                </thead>
                          </table>
                       <table class="layui-table pos-top" lay-skin="line">
                             <colgroup>
                                <col width="50">
                                 <col width="278">
                                  <col width="280">
                                    <col>
                                 </colgroup>
                                <thead>
                                    <tr>
                                        <th><input type="checkbox" name="" lay-skin="primary" lay-filter="allChoose"></th>
                                        <th>订单编号</th>
                                        <th>商品名称</th>
                                         <th>会员名称</th>
                                        <th>支付方式</th>
                                        <th>消费金额</th>
                                        <th>消费券</th>
                                        <th>时间</th>
                                    </tr>
                                </thead>
                                    <tbody>
                                        <tr>
                                           <td><input type="checkbox" name="" lay-skin="primary"></td>
                                            <td>123456789123456789</td>
                                                <td class="blus"><a href="#">土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01</a></td>
                                                    <td>ctx00003213</td>
                                                       <td>支付宝</td>
                                                        <td class="color-red">200.00元</td>
                                                              <td>201 233 25552</td>
                                                                <td ><a href="/bussiness_office/explain.aspx">2012-12-21</a></td>
                                        </tr>
                                        <tr>
                                            <td><input type="checkbox" name="" lay-skin="primary"></td>
                                            <td>123456789123456789</td>
                                            <td class="blus"><a href="#">土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01</a></td>
                                            <td>ctx00003213</td>
                                            <td>支付宝</td>
                                              <td class="color-red">200.00元</td>
                                            <td>201 233 25552</td>
                                             <td ><a href="/bussiness_office/explain.aspx">2012-12-21</a></td>
                                        </tr>
                                        <tr>
                                             <td><input type="checkbox" name="" lay-skin="primary"></td>
                                             <td>123456789123456789</td>
                                             <td class="blus"><a href="#">土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01</a></td>
                                               <td>ctx00003213</td>
                                            <td>支付宝</td>
                                            <td class="color-red">200.00元</td>
                                             <td>201 233 25552</td>
                                                <td ><a href="/bussiness_office/explain.aspx">2012-12-21</a></td>
                                        </tr> 
                                        <tr>
                                            <td><input type="checkbox" name="" lay-skin="primary"></td>
                                            <td>123456789123456789</td>
                                            <td class="blus"><a href="#">土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01</a></td>
                                            <td>ctx00003213</td>
                                            <td>支付宝</td>
                                            <td class="color-red">200.00元</td>
                                            <td>201 233 25552</td>
                                            <td ><a href="/bussiness_office/explain.aspx">2012-12-21</a></td>
                                        </tr> 
                              <tr>
                                   <td><input type="checkbox" name="" lay-skin="primary"></td>
                                 <td>123456789123456789</td>
                                 <td class="blus"><a href="#">土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01</a></td>
                                 <td>ctx00003213</td>
                                 <td>支付宝</td>
                                 <td class="color-red">200.00元</td>
                                 <td>201 233 25552</td>
                                 <td ><a href="/bussiness_office/explain.aspx">2012-12-21</a></td>
                              </tr> 
                              <tr>
                                   <td><input type="checkbox" name="" lay-skin="primary"></td>
                                 <td>123456789123456789</td>
                                 <td class="blus"><a href="#">土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01</a></td>
                                 <td>ctx00003213</td>
                                 <td>支付宝</td>
                                 <td class="color-red">200.00元</td>
                                 <td>201 233 25552</td>
                                 <td ><a href="/bussiness_office/explain.aspx">2012-12-21</a></td>
                              </tr> 
                              <tr>
                                   <td><input type="checkbox" name="" lay-skin="primary"></td>
                                 <td>123456789123456789</td>
                                 <td class="blus"><a href="#">土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01</a></td>
                                 <td>ctx00003213</td>
                                 <td>支付宝</td>
                                 <td class="color-red">200.00元</td>
                                 <td>201 233 25552</td>
                                 <td ><a href="/bussiness_office/explain.aspx">2012-12-21</a></td>
                              </tr>     
                              <tr>
                                   <td><input type="checkbox" name="" lay-skin="primary"></td>
                                 <td>123456789123456789</td>
                                 <td class="blus"><a href="#">土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01</a></td>
                                 <td>ctx00003213</td>
                                 <td>支付宝</td>
                                 <td class="color-red">200.00元</td>
                                 <td>201 233 25552</td>
                                 <td ><a href="/bussiness_office/explain.aspx">2012-12-21</a></td>
                              </tr>  
                              <tr>
                                   <td><input type="checkbox" name="" lay-skin="primary"></td>
                                 <td>123456789123456789</td>
                                 <td class="blus"><a href="#">土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01</a></td>
                                 <td>ctx00003213</td>
                                 <td>支付宝</td>
                                 <td class="color-red">200.00元</td>
                                 <td>201 233 25552</td>
                                 <td ><a href="/bussiness_office/explain.aspx">2012-12-21</a></td>
                              </tr>                                                                                                                                                                                                             <tr>
                                   <td><input type="checkbox" name="" lay-skin="primary"></td>
                                 <td>123456789123456789</td>
                                 <td class="blus"><a href="#">土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01土豆丝套餐01</a></td>
                                 <td>ctx00003213</td>
                                 <td>支付宝</td>
                                 <td class="color-red">200.00元</td>
                                 <td>201 233 25552</td>
                                 <td ><a href="/bussiness_office/explain.aspx">2012-12-21</a></td>
                              </tr>                                                
                       </tbody>
            </table>
            <div id="demo1"></div>
        </div>
        </div>
    </div>
           <uc1:bottom runat="server" ID="bottom" />
  </div>
     <script type="text/javascript" src="/bussiness_office/js/jquery-1.11.0.js"></script>
    			<script type="text/javascript" src="/bussiness_office/plugins/layui/layui.js"></script>
        <script type="text/javascript" src="/bussiness_office/plugins/layui/layui.js"></script>
		<script type="text/javascript" src="/bussiness_office/js/laypage.js"></script>
    <script type="text/javascript" src="/bussiness_office/js/record.js"></script>
       <script type="text/javascript">
           laypage({
               cont: 'demo1'
   , pages: 200 //总页数
   , groups: 4 //连续显示分页数
    , skin: "#2cb9d7"
   , skip: true,
           });
       </script>
        <script type="text/javascript">
            layui.config({
                base: '/bussiness_office/js/'
            });
            layui.use(['form', 'laypage', 'layer', 'laydate'], function () {
                var laypage = layui.laypage,
                    $ = layui.jquery,
                    layer = layui.layer, //获取当前窗口的layer对象
                    layerTips = parent.layer === undefined ? layui.layer : parent.layer, //获取父窗口的layer对象
                    form = layui.form();
            })
                $("#back").click(function () {
                    history.go(-1);
                })
                var str = $(".shop").attr("title");
                $("li[name=" + str + "]").addClass("layui-this");

                layui.use('laydate', function () {
                    var laydate = layui.laydate;
                    var start = {
                        min: laydate.now()
                      , max: '2099-06-16 23:59:59'
                      , istoday: false
                      , choose: function (datas) {
                          end.min = datas; //开始日选好后，重置结束日的最小日期
                          end.start = datas //将结束日的初始值设定为开始日
                      }
                    };

                    var end = {
                        min: laydate.now()
                      , max: '2099-06-16 23:59:59'
                      , istoday: false
                      , choose: function (datas) {
                          start.max = datas; //结束日选好后，重置开始日的最大日期
                      }
                    };

                    document.getElementById('LAY_demorange_s').onclick = function () {
                        start.elem = this;
                        laydate(start);
                    }
                    document.getElementById('LAY_demorange_e').onclick = function () {
                        end.elem = this
                        laydate(end);
                    }

                });

                layui.use('form', function () {
                    var $ = layui.jquery, form = layui.form();

                    //全选
                    form.on('checkbox(allChoose)', function (data) {
                        var child = $(data.elem).parents('table').find('tbody input[type="checkbox"]');
                        child.each(function (index, item) {
                            item.checked = data.elem.checked;
                        });
                        form.render('checkbox');
                    });

                });

         </script>  
</form>             
</body>
</html>
