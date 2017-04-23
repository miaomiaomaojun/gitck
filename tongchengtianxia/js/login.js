	

	$("#userName").focus(checkMobile);
	$("#userName").blur(checkMobile);
	$("#yanZheng").focus(checkYanzheng);	
	$("#passWord").focus(checkPwd);

//	点击登陆逻辑
	$(".c_l_deng p").click(function(){			
		if(checkMobile()&&checkPwd()&&checkYanzheng()){
			var obj={
				"status":"login",
				"userID":$("#userName").val(),				
				"password":$("#passWord").val(),
				"yanzheng":$("#yanZheng").val()
			};			
			$(".zhezhao").css("display","block");
			$(".zhezhao_bor").css("display","block");

//				$.post("url",obj,function(data){
//						if(data==1){				//成功执行这个
//						登陆成功判断是否7天自动登陆,如果是存储cookie7天		
						$.cookie("user",null);
						if($(".c_l_zid b").hasClass("active")){
							var user={
								"userID":$("#userName").val(),				
								"password":$("#passWord").val()
							}
							var strUser = JSON.stringify(user);
							$.cookie("user",strUser,{expires:7,path:"/"})							
						}
							
//							$(".zhezhao").css("display","none");
//							$(".zhezhao_bor").css("display","none");  							
//						}else{                       //失败执行这个
//							$(".zhezhao").css("display","none");
//							$(".zhezhao_bor").css("display","none");							
//						}
//					})

			setTimeout(function(){
				$(".zhezhao").css("display","none");
				$(".zhezhao_bor").css("display","none");
				var strUser1=$.cookie('user');
				alert(strUser1);
			},2000)
		}			
	})
//	验证用户名逻辑
	function checkMobile(e){
			var ev = window.event||e;
			var content=$("#userName").val();
		//	获取焦点的逻辑
			if(ev.type=="focus"){
				$(".c_l_tishi").removeClass("active");
				$(".c_l_user").addClass("active");
				return false;
			}
		//	失去焦点的逻辑
			if(ev.type=="blur"){
				if(content.length==0){
					$(".c_l_tishi").removeClass("active");
					$(".c_l_user").addClass("active");
				}else{
					var reg=/^1[3578][0-9]{9}$/;
					var flag=reg.test(content);
					if(flag){
						$(".c_l_tishi").removeClass("active");
						$(".c_l_user").addClass("active");
						return true;
					}else{
						$(".c_l_tishi").addClass("active");
						$(".c_l_user").removeClass("active");
						$(".c_l_tishi p").html("手机号格式错误");
					}
				}
				return false;
			}
		//	提交时验证逻辑
			if(content.length==0){
				$(".c_l_tishi").addClass("active");
				$(".c_l_user").removeClass("active");
				$(".c_l_tishi p").html("请输入您的手机号");
			}else{
				var reg=/^1[3578][0-9]{9}$/;
				var flag=reg.test(content);
				if(flag){
					$(".c_l_tishi").removeClass("active");
					$(".c_l_user").addClass("active");
					return true;
				}else{
					$(".c_l_tishi").addClass("active");
					$(".c_l_user").removeClass("active");
					$(".c_l_tishi p").html("手机号格式错误");
				}
			}
			return false;
		}

//	密码验证函数
	function checkPwd(e){
		var ev=window.event||e;
		var content=$("#passWord").val();
		//	获取焦点的逻辑
		if(ev.type=="focus"){
			$(".c_l_tishi").removeClass("active");
			$(".c_l_user").addClass("active");
			return false;
		}		
		//	提交时逻辑
		if(content.length==0){
			$(".c_l_tishi").addClass("active");
			$(".c_l_user").removeClass("active");
			$(".c_l_tishi p").html("请输入密码");					
		}else{
			$(".c_l_tishi").removeClass("active");				
			$(".c_l_user").addClass("active");
			return true;
		}
		return false;
	}	

//	验证码验证函数
	function checkYanzheng(e){
		var ev=window.event||e;
		var content=$("#yanZheng").val();
		//	获取焦点的逻辑
		if(ev.type=="focus"){
			$(".c_l_tishi").removeClass("active");
			$(".c_l_user").addClass("active");
			return false;
		}			
		//	提交时逻辑
		if(content.length==0){
			$(".c_l_tishi").addClass("active");
			$(".c_l_user").removeClass("active");
			$(".c_l_tishi p").html("请输入验证码");					
		}else{
			$(".c_l_tishi").removeClass("active");				
			$(".c_l_user").addClass("active");
			return true;
		}
		return false;
	}

// 点击更换验证码
	var getyanzh=true;
	getYanzheng();
	$(".c_l_yzm span").click(getYanzheng);
	function getYanzheng(){
		if(getyanzh){
			getyanzh=false;
			$.get("register.html",function(data){				
				data=1;
				if(data==1){	//验证成功执行这个
					getyanzh=true;
					$(".c_l_yzm").find("img").attr("src","/img/qq.png");
				}else {
					
				}
			});		
		}
	}







// 点击切换自动登陆
	$(".c_l_zid b").click(function(){
		$(this).toggleClass("active");
	})
	
