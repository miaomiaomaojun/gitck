<%@ Page Language="VB" AutoEventWireup="false" CodeFile="activity.aspx.vb" Inherits="office_pages_active" %>

<%@ Register Src="~/office/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/office/left_link.ascx" TagPrefix="uc1" TagName="left_link" %>
<%@ Register Src="~/office/bottom.ascx" TagPrefix="uc1" TagName="bottom" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
<style>
	select{
			width: 120px;
			border: 1px solid #e6e6e6;
		}
</style>
<body>
    <form id="form1" runat="server">
        <div class="layui-layout layui-layout-admin" style="border-bottom: solid 5px #00c1de;">
            <uc1:top runat="server" ID="top" />
            <uc1:left_link runat="server" ID="left_link" />
		<!--右边开始-->
		    <div class="layui-body" style="bottom: 0;border-left: solid 2px #00c1de;" id="admin-body">
			    <div class="layui-tab admin-nav-card layui-tab-brief" lay-filter="admin-tab">
				    <ul class="layui-tab-title">
					    <li class="layui-this">
						    <i class="fa fa-dashboard" aria-hidden="true"></i>
						    <cite>活动列表</cite>
					    </li>
				    </ul>
				    <div class="layui-tab-content" style="min-height: 150px; padding: 5px 0 0 0;background: #fff;">
					    <div class="layui-tab-item layui-show">
						    <!--内容-->
						    <div id="nav_name" name="活动列表" >
							    <div class="admin-main layui-form">
								    <div class="layui-elem-quote">
									    <div class="layui-input-inline">
										    <select name="city" lay-filter="city">
											    <option value="1">请选择城市</option>
											    <option value="2">徐州市</option>
											    <option value="3">无锡市</option>
											    <option value="4">南京市</option>
										    </select>
                                          <%--<asp:DropDownList ID="city" AutoPostBack ="true" OnSelectedIndexChanged="city_SelectedIndexChanged" runat="server"></asp:DropDownList>--%>
									    </div>
									    <div class="layui-input-inline">
										    <select name="firstclass" lay-filter="firstclass">
											    <option value="1">一级类目</option>
											    <option value="2">美食</option>
											    <option value="3">美容</option>
											    <option value="4">娱乐</option>
										    </select>
									    </div>
									    <div class="layui-input-inline" >
										    <select name="secondclass" lay-filter="secondclass">
											    <option value="1">二级类目</option>
											    <option value="2">火锅</option>
											    <option value="3">烧烤</option>
											    <option value="4">饮料</option>
										    </select>
									    </div>
									    <a href="/office/pages/addactivity.aspx" class="layui-btn layui-btn-small" id="add">
										    <i class="layui-icon">&#xe608;</i> 添加信息
									    </a>

									    <a href="#" class="layui-btn layui-btn-small" id="getSelected">
										    <i class="fa fa-shopping-cart" aria-hidden="true"></i> 获取全选信息
									    </a>
									    <div class="layui-input-inline">
										    <input type="text" name="password" lay-verify="pass" placeholder="请输入活动名称" autocomplete="off" class="layui-input">
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
							    <fieldset class="layui-elem-field">
								    <legend>活动列表</legend>
								    <div class="layui-field-box layui-form">
									    <table class="layui-table admin-table">
										    <thead>
											    <tr>
												    <th style="width: 30px;"><input type="checkbox" lay-filter="allselector" lay-skin="primary"></th>
												    <th>编号</th>
                                                    <th>城市</th>
												    <th>活动名称</th>
												    <th>活动分类</th>
												    <th>开始时间</th>
												    <th>结束时间</th>
												    <th>充值金额</th>
												    <th>赠送积分</th>
												    <th>使用周期</th>
												    <th>单个金额</th>
												    <th>单个积分</th>
                                                    <th>使用数量</th>
												    <th>活动数量</th>
												    <th>操作</th>
												    <th>创建人</th>
											    </tr>
										    </thead>
										    <tbody id="content">
											    <tr>
												    <td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
												    <td>1</td>
                                                    <td>徐州市</td>
												    <td>活动名称带的</td>
												    <td>美食-火锅</td>
												    <td>2017-03-02 8：00</td>
												    <td>2017-03-02 8：00</td>
												    <td>1000</td>
												    <td>500</td>
												    <td>1年</td>
												    <td>250元</td>
												    <td>50</td>
                                                    <td>2</td>
												    <td>2000</td>
												    <td>
													    <a href="/office/pages/addactivity.aspx" data-opt="edit" class="layui-btn layui-btn-mini bianji">编辑</a>
													    <a href="javascript:;" data-id="1" data-opt="del" class="layui-btn layui-btn-danger layui-btn-mini del">删除</a>
												    </td>
												    <td>里某某</td>
											    </tr>
											    <tr>
												    <td style="width: 30px;"><input type="checkbox" lay-skin="primary"></td>
												    <td>2</td>
                                                    <td>徐州市</td>
												    <td>活动名称带的</td>
												    <td>美食-火锅</td>
												    <td>2017-03-02 8：00</td>
												    <td>2017-03-02 8：00</td>
												    <td>1000</td>
												    <td>500</td>
												    <td>1年</td>
												    <td>250元</td>
												    <td>50</td>
                                                    <td>2</td>
												    <td>2000</td>
												    <td>
													    <a href="/office/pages/addactivity.aspx" data-opt="edit" class="layui-btn layui-btn-mini bianji">编辑</a>
													    <a href="javascript:;" data-id="1" data-opt="del" class="layui-btn layui-btn-danger layui-btn-mini del">删除</a>
												    </td>
												    <td>里某某</td>
											    </tr>

										    </tbody>
									    </table>
									    <div id="demo1"></div>
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
                //分页
		        laypage({
		            cont: 'demo1',
		            pages: 10, //总页数
		            groups: 5, //连续显示分页数
		            first: "首页",
		            last: "末页",
		            prev: "上一页",
		            next: "下一页",
		            skip: true
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
		        
		        //全选
		        form.on('checkbox(allselector)', function (data) {
		            var child = $(data.elem).parents('table').find('tbody input[type="checkbox"]');
		            child.each(function (index, item) {
		                item.checked = data.elem.checked;
		            });
		            form.render('checkbox');
		        });
		        //获取所有选择的列
		        $('#getSelected').on('click', function () {
		            var names = '';
		            $('#content').children('tr').each(function () {
		                var $that = $(this);
		                var $cbx = $that.children('td').eq(0).children('input[type=checkbox]')[0].checked;
		                if ($cbx) {
		                    var n = $that.children('td:last-child').children('a[data-opt=edit]').data('name');
		                    names += n + ',';
		                }
		            });
		            layer.msg('你选择的名称有：' + names);
		        });
                //搜索
		        $('#search').on('click', function () {
		            parent.layer.alert('你点击了搜索按钮')
		        });
                
		        var addBoxIndex = -1;
		        $('#aadd').on('click', function () {
		            if (addBoxIndex !== -1) {
		                return;
		            }
		            addBoxIndex = layer.open({
		                type: 1,
		                title: '添加活动',
		                content: $("#tanchuang"),
		                btn: ['保存', '取消'],
		                shade: [0.6, '#393D49'],
		                offset: ['100px', '30%'],
		                area: ['550px', '500px'],
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
		                    //弹出窗口成功后渲染表单
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
		                     addBoxIndex = -1;
		                }
		            });
		            
		        });
		        /*删除*/
		        $(".del").click(function () {
		            $(this).parents("tr").remove();
		        });
		        var bjBoxIndex = -1;
		        $(".bianji").on('click', function () {
		            if (bjBoxIndex !== -1) { return;}
		            //本表单通过ajax加载 --以模板的形式，当然你也可以直接写在页面上读取
		            var $this = $(this),
                    tr=$this.parents("tr")
		            bjBoxIndex = layer.open({
		                type: 1,
		                title: '添加活动',
		                content: $("#tanchuang"),
		                btn: ['保存', '取消'],
		                shade: [0.6, '#393D49'],
		                offset: ['100px', '30%'],
		                area: ['550px', '500px'],
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
		                    //弹出窗口成功后渲染表单
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
		                    addBoxIndex = -1;
		                }
		            });
		        });

		    });
		</script>
	   
        
    </form>
</body>
</html>
