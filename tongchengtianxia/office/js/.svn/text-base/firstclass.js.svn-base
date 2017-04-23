
$("#jiantou").toggle(function() {
	$("#hidebox").slideDown();
}, function() {
	$("#hidebox").slideUp();
});
$("#hidebox ul li").click(function() {
	$(this).addClass("active").siblings().removeClass("active")
	$("#column").html($(this).html());
	$("#hidebox").slideUp(400);
	/*$("#text").html($(this).html())*/
});
/*判断是否推荐是字体变色*/
	$(document).ready(function() {
				var pd = $(".tj p");
				$.each(pd, function(a,b) {
					if($(b).html() == "是"){
						$(this).css("color","#009900");
					};
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
		
		layui.use('form', function() {});			
	});