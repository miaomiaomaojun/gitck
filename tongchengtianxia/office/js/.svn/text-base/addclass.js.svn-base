	$(document).ready(function() {
				$("#submit").click(function() {
					var keyVal = $("#classname").val();
					if(keyVal == "") {
						$("#warning").html("输入不能为空");
						$("#warning").show();
					} else {
						$("#warning").hide();
						var reg = /^[\u4e00-\u9fa5\da-zA-Z]+$/;
						if(!reg.test(keyVal)) {
							$("#warning").html("格式不正确");
							$("#warning").show();
						};
					};
					var paixu = $("#paixu").val();
					if(paixu == "") {
						$("#alert").html("输入不能为空");
						$("#alert").show();
					} else {
						$("#alert").hide();
						var reg = /^\d+$/;
						if(!reg.test(paixu)) {
							$("#alert").html("只能输入数字");
							$("#alert").show();
						};
					};

				});
				
			});
				$("#choosepre p,#choosepre span").click(function() {
					$("#preclass").slideDown();
				});
				$("#preclass ul li").click(function() {
				$(this).addClass("active").siblings().removeClass("active");
				$("#choosepre").css("color", "#231815");
				$("#choosepre p").html($(this).html());
				$("#preclass").slideUp(400);
			});

				$("#kinds p,#kinds span").click(function() {
					$("#hidebox").slideDown();
				});
		
			$("#hidebox ul li").click(function() {
				$(this).addClass("active").siblings().removeClass("active");
				$("#kinds").css("color", "#231815");
				$("#kinds p").html($(this).html());
				$("#hidebox").slideUp(400);
				var Val=$("#kinds p").html();
				if(Val == "二级类目") {
						$("#secondhide").show();
					} else {
						$("#secondhide").hide();	
					}
				/*$("#text").html($(this).html())*/
			});
			$("div.holder").jPages({
				containerID: "contcent", //需要被分页的容器
				previous: "《 上一页", //前进后退 内容字
				next: "下一页 》",
				first: "首页",
				last: "尾页",
				startPage: 1, //起始显示的页码
				perPage: 5, //每页的内容数量
				midRange: 2, //分页器中间页数
				startRange: 1, //开头页数
				endRange: 1, //结尾页数	

			});