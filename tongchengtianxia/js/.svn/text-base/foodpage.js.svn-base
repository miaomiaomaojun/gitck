window.onload = function() {
			$("#arrow").mouseover(function() {
				$(this).removeClass().addClass('hoverup')
				$("#mask1").stop(true).slideDown(400);

			});
			$("#arrow").mouseleave(function() {
				$(this).removeClass().addClass('arrow')
				$("#mask1").stop(true).slideUp(400);

			});
			$("#xiaoliang").toggle(function() {
					$(this).css("background-position-x", "-346px");
				},
				function() {
					$(this).css("background-position-x", "-304px");
				},
				function() {
					$(this).css("background-position-x", "-41px");
				}
			);
			$("#price").toggle(function() {
					$(this).css("background-position-x", "-100px");
				},
				function() {
					$(this).css("background-position-x", "-124px");
				},
				function() {
					$(this).css("background-position-x", "-68px");
				}
			);
			$("#time").toggle(function() {
					$(this).css("background-position-x", "-302px");
				},
				function() {
					$(this).css("background-position-x", "-345px");
				},
				function() {
					$(this).css("background-position-x", "-266px");
				}
			);

			$("div.holder").jPages({
				containerID: "itemContainer", //需要被分页的容器
				previous: "", //前进后退 内容字
				next: "",
				last: "尾页",
				startPage: 1, //起始显示的页码
				perPage: 8, //每页的内容数量
				midRange: 2, //分页器中间页数
				startRange: 1, //开头页数
				endRange: 1 //结尾页数	
			});

		};