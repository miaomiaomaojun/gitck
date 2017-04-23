
	$(document).ready(function(){
		//检测cookie 自动登陆
		var dengluzhuangtai=false;
		(function(){
			var strUser1=$.cookie('user');
//			console.log(strUser1);
			if(strUser1){
				var strUser2=JSON.parse(strUser1);
				var obj={
					"status":"login",
					"userID":strUser2.userID,
					"password":strUser2.password
				}
	//			$.post("url",obj,function(data){
	//				if(data==1){		//成功执行这个
						dengluzhuangtai=true;
						$(".willlogin").removeClass("active");
						$(".loginer").addClass("active");
						$(".loginer a .yonghu").html(obj.userID);
	//				}else{                       //失败执行这个
	//					
	//				}
	//			})
					
			}
			//退出登录
			$(".loginer span").click(function(){
				$(".willlogin").addClass("active");
				$(".loginer").removeClass("active");
			})
		})();
		
		//是否登录状态
		$(".h_left a").click(function(){
			if(dengluzhuangtai){
				
			}else{
				location.href="/register/login.html"
				return false;
			}
			
		})
				
		//头部
		var slregion=$(".header .wrap ul li").has(".dls");
		slregion.mouseenter(function(){
			$(this).children(".dls").stop(true).slideDown(300);
		})
		slregion.mouseleave(function(){
			$(this).children(".dls").stop(true).slideUp(300);
		});
		
	})
