$(".neirong").each(function() {
				var maxwidth = 60;
				if($(this).text().length > maxwidth) {
					$(this).text($(this).text().substring(0, maxwidth));
					$(this).html($(this).html() + '...');
				}
			});
			$(".divr_contain").each(function() {
				var maxwidth = 80;
				if($(this).text().length > maxwidth) {
					$(this).text($(this).text().substring(0, maxwidth));
					$(this).html($(this).html() + '...');
				}
			});
			$("div.holder").jPages({
				containerID: "contcent", //需要被分页的容器
				previous: "《 上一页", //前进后退 内容字
				next: "下一页 》",
				/*first: "首页",
				last: "尾页",*/
				startPage: 1, //起始显示的页码
				perPage: 10, //每页的内容数量
				midRange: 2, //分页器中间页数
				startRange: 1, //开头页数
				endRange: 1, //结尾页数	
				callback: function(pages, items) {
					$("#legend1").html(pages.current + " / " + pages.count);
					$("#legend2").html(" 共 " + items.count + " 条 ");
				}

			});