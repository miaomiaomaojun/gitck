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
			$('.add').click(function() {
				$('.zhezhao').show();
				$('.zhezhao_tianjia').show();
			});
			$('.zhezhao_close').click(function() {
				$('.zhezhao').hide();
				$('.zhezhao_tianjia').hide();
			});
			$('.editbank').click(function() {
				$('.zhezhao').show();
				$('.zhezhao_bianji').show();
			});
			$('.zhezhao_close').click(function() {
				$('.zhezhao').hide();
				$('.zhezhao_bianji').hide();
			});
			$("#submit").click(function() {
					var keyVal = $("#yhname").val();
					if(keyVal == "") {
						$("#alert").html("输入不能为空");
						$("#alert").show();
					} else {
						$("#alert").hide();
						var reg = /^[a-zA-Z\u4e00-\u9fa5]+$/;
						if(!reg.test(keyVal)) {
							$("#alert").html("格式不正确");
							$("#alert").show();
						};
					};
				});
				$("#submitbj").click(function() {
					var keyVal = $("#yhnamebj").val();
					if(keyVal == "") {
						$("#alertbj").html("输入不能为空");
						$("#alertbj").show();
					} else {
						$("#alertbj").hide();
						var reg = /^[a-zA-Z\u4e00-\u9fa5]+$/;
						if(!reg.test(keyVal)) {
							$("#alertbj").html("格式不正确");
							$("#alertbj").show();
						};
					};
				});		