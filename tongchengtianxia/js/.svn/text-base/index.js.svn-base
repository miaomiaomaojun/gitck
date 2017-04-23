
(function(){
	$(document).ready(function(){				
		//导航效果
		$(".banner_nav_main>li").mouseenter(function(){
			$(this).children(".banner_nav_hidden").show();
		}).mouseleave(function(){
			$(this).children(".banner_nav_hidden").hide();
		});
	
		//回到顶部
		$(".gototop div").click(function(){
			$(window).scrollTop(0);
		});

		$(window).scroll(function(){
//			$(window).scrollTop(1549);
//			console.log($(".zhutishangpin").offset().top);  //元素相对于页面顶部的高度
//			console.log($(window).scrollTop());					滚动条高度
//			console.log($(window).height());					视窗的高度
//			滚动高度+视窗高度>元素相对于顶部的高度,就可以看得见了
			var height1=$(window).scrollTop()+$(window).height();
			var height2=$(window).scrollTop()+100;
			if(height1>=$(".zhutishangpin").offset().top){		//滚动到美食了，返回顶部出现
				$(".gototop").show();
				if(height1>=$(".telephone").offset().top){  	//判断是否滚动到最底下了。决定返回顶部是否移动
					$(".gototop").addClass("active");
				}else{
					$(".gototop").removeClass("active");
				}
//				根据滚动,改变楼层显示的
				if(height2>=$(".photography.louceng").offset().top){	
					$(".gototop ul li").removeClass("active");
					$(".gototop ul .photography").addClass("active");
				}else if(height2>=$(".beautiful.louceng").offset().top){
					$(".gototop ul li").removeClass("active");
					$(".gototop ul .beautiful").addClass("active");
				}else if(height2>=$(".service.louceng").offset().top){
					$(".gototop ul li").removeClass("active");
					$(".gototop ul .service").addClass("active");
				}else if(height2>=$(".supermarket.louceng").offset().top){
					$(".gototop ul li").removeClass("active");
					$(".gototop ul .supermarket").addClass("active");
				}else if(height2>=$(".recreation.louceng").offset().top){
					$(".gototop ul li").removeClass("active");
					$(".gototop ul .recreation").addClass("active");
				}else if(height2>=$(".hotel.louceng").offset().top){
					$(".gototop ul li").removeClass("active");
					$(".gototop ul .hotel").addClass("active");
				}else{
					$(".gototop ul li").removeClass("active");
					$(".gototop ul .food").addClass("active");
				}
			}else{							//没有滚动到美食，返回顶部隐藏
				$(".gototop").hide();
			}			
		})
				
		
	//	轮播图
		var arr=["/Myweb/img/huo(1).jpg","/Myweb/img/huo(2).jpg","/Myweb/img/huo(3).jpg","/Myweb/img/huo(4).jpg","/Myweb/img/huo(5).jpg"];			
		lunbo($(".banner_banners"),arr);
	/*
	*	轮播图函数  
	* ele是一个jquery对象。用来放轮播图用的的外壳 如$(".abc")
	* arrX是图片地址数组（绝对）["/img/huo(1).jpg","/img/huo(2).jpg"]
	* 
	*/
		function lunbo(ele,arrX){
			var img_top = "<div class='img_top' index=0><a href=' '><img src='"+arrX[0]+"' style='z-index:1'/></a><div>";					
			ele.append(img_top);								
		//生成底部圆点按钮
			var bottom_dv = "<div class='bottom_dv'></div>";
			ele.append(bottom_dv);					
			for(var i=1;i<=arrX.length;i++){
				var btn_bottom = "<div class='btn_bottom' index='"+i+"'></div>";
				$(".bottom_dv").append(btn_bottom);	
			};
			$('.btn_bottom:first').addClass("active"); 	//第一个按钮是选中的		
		//生成左右两个按钮
			var btn_per = "<div class='btn_per btn_change'><span></span></div>";
			var btn_next= "<div class='btn_next btn_change'><span></span></div>";
			ele.append(btn_per);
			ele.append(btn_next);
		
		//点点击事件
			$('.btn_bottom').click(function(){
				$(".img_top img").stop(true,true);
				$(".img_top img:not(:first)").remove();
				clearTimeout(step);
				window.clearTimeout(step);
				var a = $(this).index();
				console.log(a);
				$(".img_top").attr("index",a-1);						
				goBanner(true,1);			
			});
			//上一张
			$(".btn_per").click(function(){
				$(".img_top img").stop(true,true);
				$(".img_top img:not(:first)").remove();
				clearTimeout(step);
				window.clearTimeout(step);
				var a=$('.btn_bottom.active').attr("index")-1;
				if(a==0){a=4}else{a=a-1;};				
				$(".img_top").attr("index",a-1);					
				goBanner(true,1);
			});
			//下一张
			$(".btn_next").click(function(){
				$(".img_top img").stop(true,true);
				$(".img_top img:not(:first)").remove();
				clearTimeout(step);
				window.clearTimeout(step);
				var a=$('.btn_bottom.active').attr("index");
				$(".img_top").attr("index",a-1);						
				goBanner(true,1);
			});
			//鼠标移出事件
			ele.mouseleave(function(){
				$(".btn_change").css("background","")
				$(".img_top img").stop(true,true);
				$(".img_top img:not(:first)").remove();
				clearTimeout(step);
				goBanner();
			});
			ele.mouseenter(function(){
				$(".btn_change").css("background","#000")
			});
			goBanner();
			var step;
			function goBanner(once,seconds){
				var se=seconds?seconds:2000;
				step = setTimeout(function(){
					var i = parseInt($(".img_top").attr("index"))+1;
					if(i==arrX.length){i=0;}				
					$('.btn_bottom').removeClass("active").eq(i).addClass("active");	
					$(".img_top").attr("index",i);
					$(".img_top a").append("<img src='"+arrX[i]+"' style='z-index:0'  >");
					$(".img_top img:first").fadeOut(500,function(){						
						$(".img_top img:first").remove();
						$(".img_top img:first").css("z-index",1);								
						if(!once){goBanner();}
					})
				},se)			
			}
		};

	
	
	})
})()

