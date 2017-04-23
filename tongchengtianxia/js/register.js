	
		var userName=document.getElementById("username");    	//用户名输入框
		var f_tip_span1=document.getElementById("f_tip_span1");
		var f_tip_i1=document.getElementById("f_tip_i1");
		userName.onfocus=checkMobile;
		userName.onkeyup=checkMobile;
		
		$("#f_iptyanzheng").keyup(checkYanzheng);
		$("#f_iptyanzheng").focus(checkYanzheng);
		
		$("#password").focus(checkPwd);
		$("#password").keyup(checkPwd);		
		$("#password").keyup(pwdLevel);
		
		$("#password2").focus(checkPwd2);
		$("#password2").keyup(checkPwd2);

//	点击注册逻辑
		$("#register").click(function(){			
			if(checkMobile()&&checkYanzheng()&&checkPwd()&&checkPwd2()){
				var obj={
					"status":"register",
					"userID":userName.value,
					"yanzheng":$("#f_iptyanzheng").val(),
					"password":$("#password").val()
				};			
				$(".zhezhao").css("display","block");
				$(".zhezhao_bor").css("display","block");
//				编写提交注册信息
//				$.post("url",obj,function(data){
//						if(data==1){				//成功执行这个
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
				},2000)
			}			
		})
//		验证用户名逻辑
	function checkMobile(e){
			var ev = window.event||e;
			var content=userName.value;
		//	获取焦点的逻辑
			if(ev.type=="focus"){
				if(content.length==0){
					f_tip_i1.className="";
					f_tip_span1.innerHTML="请输入您的手机号";
				}
				return false;
			}			
		//	失去焦点的逻辑
			if(ev.type=="keyup"){
				if(content.length==0){
					f_tip_i1.className="";
					f_tip_span1.innerHTML="";
				}else{
					var reg=/^1[3578][0-9]{9}$/;
					var flag=reg.test(content);
					if(flag){
						f_tip_i1.className="";   
						f_tip_span1.innerHTML="";
						
//						编写验证用户名是否可用程序
//						$.post("url",{"numb":content},function(data){
//							if(data==1){				//成功执行这个
//								f_tip_i1.className="ok";   
//								f_tip_span1.innerHTML="";
//							}else{                       //失败执行这个
//								f_tip_i1.className="error";   
//								f_tip_span1.innerHTML="手机已注册";
//							}
//						})
						
					}else{
						f_tip_i1.className="error";					
						f_tip_span1.innerHTML="手机号格式错误";
					}
				}
				return false;
			}
		//	提交时验证逻辑
			if(content.length==0){
				f_tip_i1.className="error";
				f_tip_span1.innerHTML="请输入您的手机号";
			}else{
				var reg=/^1[3578][0-9]{9}$/;
				var flag=reg.test(content);
				if(flag){
					f_tip_i1.className="ok";					
					f_tip_span1.innerHTML="";
					return true;
				}else{
					f_tip_i1.className="error";					
					f_tip_span1.innerHTML="手机号格式错误";
				}
			}
			return false;
		}

//	验证码验证函数
	function checkYanzheng(e){
		var ev=window.event||e;
		var content=$("#f_iptyanzheng").val();
		if(ev.type=="focus"){
			if(content.length==0){
				$("#f_tip_i2")[0].className="";
				$("#f_tip_span2").html("请输入验证码");
				return false;	
			}else{
				$("#f_tip_i2")[0].className="";
				$("#f_tip_span2").html("");
				return true
			}			
		}
		
		if(ev.type=="keyup"){
			if(content.length==0){
				$("#f_tip_i2")[0].className="";
				$("#f_tip_span2").html("");
				return false;	
			}else{
				$("#f_tip_i2")[0].className="";
				$("#f_tip_span2").html("");
				return true
			}			
		}
		//	提交时逻辑
		if(content.length==0){
			$("#f_tip_i2")[0].className="error";
			$("#f_tip_span2").html("请输入验证码");
			return false;	
		}else{
			$("#f_tip_i2")[0].className="";
			$("#f_tip_span2").html("");
			return true
		}	
	}

//	密码验证函数
	function checkPwd(e){
			var ev=window.event||e;
			var content=$("#password").val();
			//	获取焦点的逻辑
			if(ev.type=="focus"){
				if(content.length==0){
					$("#f_tip_i3").removeClass();
					$("#f_tip_span3").html("请输入5-15位字符密码");
				}
				return false;
			}
			//	失去焦点逻辑
			if(ev.type=="keyup"){
				if(content.length==0){
					$("#f_tip_i3").removeClass();
					$("#f_tip_span3").html("");	
				}else{
					var reg=/^.{5,15}$/;
					var flag=reg.test(content);
					if(flag){
						$("#f_tip_i3")[0].className="ok";
						$("#f_tip_span3").html("");
						return true;
					}else{
						$("#f_tip_i3")[0].className="error";
						$("#f_tip_span3").html("密码格式不正确");
					}
				}
				return false;
			}
			//	提交时逻辑
			if(content.length==0){
				$("#f_tip_i3")[0].className="error";
				$("#f_tip_span3").html("密码格式不正确");								
			}else{
				var reg=/^.{6,20}$/;
				var flag=reg.test(content);
				if(flag){
					$("#f_tip_i3")[0].className="ok";
					$("#f_tip_span3").html("");					
					return true;
				}else{
					$("#f_tip_i3")[0].className="error";
					$("#f_tip_span3").html("密码格式不正确");
				}
			}
			return false;
		}	

//	密码确认函数
	function checkPwd2(e){
		var content2=$("#password2").val();
		var content=$("#password").val();		
		var ev=window.event||e;
		if(ev.type=="focus"){
			if(content2.length==0){
				$("#f_tip_i4").removeClass();
				$("#f_tip_span4").html("请再次输入密码");
			}
			return false;
		}
		if(ev.type=="keyup"){
			if(content2.length==0){
				$("#f_tip_i4").removeClass();
				$("#f_tip_span4").html("");
			}else{			
				if(content==content2){
					$("#f_tip_i4")[0].className="ok";
					$("#f_tip_span4").html("");
					return true;
				}else{
					$("#f_tip_i4")[0].className="error";
					$("#f_tip_span4").html("确认密码错误");
				}
			}
			return false;
		}
		
		if(content2.length==0){
			$("#f_tip_i4")[0].className("error");
			$("#f_tip_span4").html("请再次输入密码");
		}else{			
			if(content==content2){
				$("#f_tip_i4")[0].className="ok";
				$("#f_tip_span4").html("");
				return true;
			}else{
				$("#f_tip_i4")[0].className="error";
				$("#f_tip_span4").html("密码不一致");
			}			
		}
		return false;
	}
	
//密码等级显示	
	function pwdLevel(){
		var content=$(this).val()
		var index=getLevel(content);
		if(index.length==0){
			$("#q_xianshi").removeClass();
		}else{
			switch (index){
				case 1:
					$("#q_xianshi")[0].className="ruo";
				break;
				case 2:
					$("#q_xianshi")[0].className="zhong";
				break;
				case 3:
					$("#q_xianshi")[0].className="qiang";
				break;
			}
		}
	}
//计算密码等级
	function getLevel(pwd){ 
		var level=0;
		var numreg=/\d+/;	
		var wordreg=/[a-zA-Z]+/;
		var otherreg=/[^\da-zA-Z]+/;
		if(numreg.test(pwd)){
			level++;
		}
		if(wordreg.test(pwd)){
			level++;
		}
		if(otherreg.test(pwd)){
			level++;
		}
		return level;
	}

//	获取验证码
	(function(){
		var times;
		var flage=true;
		$(".yanzhengma").click(function(){
			if(checkMobile()){
				if(flage){
					flage=false;
					var miao=60;
					$("#f_iptyanzheng").removeAttr("disabled");				
		/*
		 *			编写请求发送验证码的程序
		 * 			obj={
		*				userID:$("#userName").val(),
		*				data:"请求验证码"
		*			}
		*			$.post("login.html",obj,function(data){
		*				data=1;
		*				if(data==1){		//验证成功执行这个
		*					
		*				}else if(data==2){
		*					
		*				}
		*			});		
		 * 
		 * 
		 * */				
					
					$(this).html("重新发送（"+miao+"）");				
					$(this).addClass("disabel")
					times=setInterval(function(){
						miao--;
						$(".yanzhengma").html("重新发送（"+miao+"）");
						if(miao<0){
							$(this).removeClass("disabel");
							$(".yanzhengma").html("获取验证码");
							flage=true;
							clearInterval(times);			
						}
					},1000)
				}
			}
						
		})
	})()
	