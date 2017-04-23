<%@ Page Language="VB" AutoEventWireup="false" CodeFile="addactivity.aspx.vb" Inherits="office_pages_addactivity" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>活动列表</title>
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
                            <cite>新增活动</cite>
                        </li>
                    </ul>
                    <div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0; background: #fff;">
                        <div class="layui-tab-item layui-show">
                            <!--内容-->
                            <div id="nav_name" name="活动列表">
                                <div style="padding: 15px;">
                                    <div class="layui-form">
                                        <!--数字-->
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">活动名称</label>
                                            <div class="layui-input-inline">
                                                <input type="text" name="title" lay-verify="required" autocomplete="off" class="layui-input">
                                            </div>
                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">活动区域</label>
                                            <div class="layui-input-inline">
                                                <select name="city" lay-filter="city">
                                                    <option value="">请选择区域</option>
                                                    <option value="1">徐州市</option>
                                                    <option value="2">南京市</option>
                                                    <option value="3">无锡市</option>
                                                </select>
                                            </div>
                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">一级类目</label>
                                            <div class="layui-input-inline">
                                                <select name="firstclass" lay-filter="firstclass">
                                                    <option value="">一级类目</option>
                                                    <option value="1">美食</option>
                                                    <option value="2">旅游</option>
                                                    <option value="3">美容</option>
                                                </select>
                                            </div>
                                            <div class="layui-input-inline">
                                                <select name="secondclass" lay-filter="secondclass">
                                                    <option value="">二级类目</option>
                                                    <option value="1">烧烤</option>
                                                    <option value="2">西餐</option>
                                                    <option value="3">自助餐</option>
                                                </select>
                                            </div>
                                        </div>

                                        <!--数字-->
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">需充值金额</label>
                                            <div class="layui-input-inline">
                                                <input type="number" name="number" lay-verify="number" autocomplete="off" class="layui-input">
                                            </div>
                                        </div>
                                        <!--数字-->
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">使用周期</label>
                                            <div class="layui-input-inline">
                                                <input type="number" name="number" lay-verify="number" autocomplete="off" class="layui-input">
                                            </div>
                                        </div>
                                        <!--数字-->
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">使用数量</label>
                                            <div class="layui-input-inline">
                                                <input type="number" name="number" lay-verify="number" autocomplete="off" class="layui-input">
                                            </div>
                                        </div>

                                        <div class="layui-form-item">
                                            <label class="layui-form-label">单个金额</label>
                                            <div class="layui-input-inline">
                                                <input type="number" name="number" lay-verify="number" autocomplete="off" class="layui-input">
                                            </div>

                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">单个积分</label>
                                            <div class="layui-input-inline">
                                                <input type="number" name="number" lay-verify="number" autocomplete="off" class="layui-input">
                                            </div>
                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">开始时间</label>
                                            <div class="layui-input-inline">
                                                <input type="text" name="date" id="date" lay-verify="date" placeholder="yyyy-mm-dd" autocomplete="off" class="layui-input" onclick="layui.laydate({ elem: this })">
                                            </div>

                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">结束时间</label>
                                            <div class="layui-input-inline">
                                                <input type="text" name="date" id="Text1" lay-verify="date" placeholder="yyyy-mm-dd" autocomplete="off" class="layui-input" onclick="layui.laydate({ elem: this })">
                                            </div>

                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">活动数量</label>
                                            <div class="layui-input-inline">
                                                <input type="number" name="number" lay-verify="number" autocomplete="off" class="layui-input">
                                            </div>

                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label">活动创建人</label>
                                            <div class="layui-input-inline">
                                                <input type="text" name="" lay-verify="renming" placeholder="请输入" autocomplete="off" class="layui-input">
                                            </div>

                                        </div>
                                        <div class="layui-form-item">
                                            <label class="layui-form-label"></label>
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

                $("#back").click(function () {
                    history.go(-1);
                })

				//验证
				form.verify({
				  	renming: [
				   /[\u4e00-\u9fa5]{2,}/
				    ,'请输入完整的中文姓名'
				  ] 
				}); 
				
				//下拉列表
		        form.on('select(city)', function(data){
					console.log(data.elem); //得到select原始DOM对象
					console.log(data.value); //得到被选中的值
					console.log(data.othis); //得到美化后的DOM对象
				});
				form.on('select(firstclass)', function(data){
					console.log(data.elem); //得到select原始DOM对象
					console.log(data.value); //得到被选中的值
					console.log(data.othis); //得到美化后的DOM对象
				});
				form.on('select(secondclass)', function(data){
					console.log(data.elem); //得到select原始DOM对象
					console.log(data.value); //得到被选中的值
					console.log(data.othis); //得到美化后的DOM对象
				});



                //添加nav选中项
                var str = $("#nav_name").attr("name");
                $("dd[title=" + str + "]").addClass("layui-this").parents("li").addClass("layui-nav-itemed");

              
            });
        </script>


    </form>
</body>
</html>
