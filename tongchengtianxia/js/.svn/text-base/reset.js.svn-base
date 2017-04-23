	
$("#userName").focus(checkMobile);
$("#userName").blur(checkMobile);
$("#yanZheng1").focus(checkYanzheng);
var diyibu=false;
var dierbu=false;
//	第一步点击登陆逻辑
$(".c_l_deng p").click(function(){			
	if(checkMobile()&&checkYanzheng()){
		var obj={
			"userID":$("#userName").val(),				
			"yanzheng":$("#yanZheng1").val()
		};
		var str=$("#userName").val();
		var strs=str.substr(0,3)+"****"+str.substr(7,4);
		$(".center1 .c1_liss_tate p span").html(strs);
		//测试跳转第二部程序
		$.get("login.html",obj,function(data){
			data=1;
			if(data==1){		//验证成功执行这个
				//页面切换
				diyibu=true;  //防止直接控制第二页显示
				$(".center0").removeClass("active");
				$(".center1").addClass("active");
			}else if(data==2){
				//验证码错误		
				$(".c_l_wrong p").addClass("active");
				$(".c_l_wrong p").html("验证码错误");
			}else if(data==3){
				//账户不存在
				$(".c_l_wrong p").addClass("active");
				$(".c_l_wrong p").html("账户不存在");
			}	
		});	
	}
});

//第一步点击获取验证码测试程序
var getyanzh=true;
$(".c_l_yzm div").click(function(){
	if(getyanzh){
		getyanzh=false;
		$.get("login.html",function(data){
			getyanzh=true;
			data=1;
			if(data==1){	//验证成功执行这个
				$(".c_l_yzm img").attr("src","/img/qq.png")
			}else {
				
			}
		});		
	}
})
	
	
	
//	第一步验证用户名逻辑
function checkMobile(e){
	var ev = window.event||e;
	var content=$("#userName").val();
//	获取焦点的逻辑
	if(ev.type=="focus"){
		$(".c_l_wrong p").removeClass("active");					
		return false;
	}
//	失去焦点的逻辑
	if(ev.type=="blur"){
		if(content.length==0){
			$(".c_l_wrong p").removeClass("active");
		}else{
			var reg=/^1[3578][0-9]{9}$/;
			var flag=reg.test(content);
			if(flag){
				$(".c_l_wrong p").removeClass("active");
				return true;
			}else{
				$(".c_l_wrong p").addClass("active");
				$(".c_l_wrong p").html("请输入正确的手机号");
			}
		}
		return false;
	}
//	提交时验证逻辑
	if(content.length==0){
		$(".c_l_wrong p").addClass("active");
	}else{
		var reg=/^1[3578][0-9]{9}$/;
		var flag=reg.test(content);
		if(flag){
			$(".c_l_wrong p").removeClass("active");
			return true;
		}else{
			$(".c_l_wrong p").addClass("active");
			$(".c_l_wrong p").html("请输入正确的手机号");
		}
	}
	return false;
}
		
//	第一步验证码 验证函数
function checkYanzheng(e){
	var ev=window.event||e;
	var content=$("#yanZheng1").val();
	//	获取焦点的逻辑
	if(ev.type=="focus"){
		$(".c_l_wrong p").removeClass("active");
		return false;
	}			
	//	提交时逻辑
	if(content.length==0){
		$(".c_l_wrong p").addClass("active");
		$(".c_l_wrong p").html("请输入验证码");					
	}else{
		$(".c_l_wrong p").removeClass("active");				
		return true;
	}
	return false;
}


//第二步  
		//第二步获取验证码
(function(){
	var times;
	var flage=true;
	$(".yanzhengma").click(function(){
		if(diyibu){		//防止直接控制第二页显示
			if(flage){
				flage=false;
				var miao=60;
				$("#yanZheng2").removeAttr("disabled");
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
						$(".yanzhengma").html("获取验证码").removeClass("disabel");					
						flage=true;
						clearInterval(times);			
					}
				},1000)
			}
		}
	})
})()

		//第二部返回上一步
$(".c1_liss_deng span").click(function(){
	diyibu=false;
	$(".center1").removeClass("active");
	$(".center0").addClass("active");
})

		//第二步提交
$(".c1_liss_deng div").click(function(){
	if(diyibu){
		var yanzheng=$("#yanZheng2").val();
		if(yanzheng==""){
			alert("请输入验证码")
		}else{
			obj={
				username:$("#userName").val(),
				yanzhengma:$("#yanZheng2").val()
			}
			//提交专第三步测试程序
			$.get("register.html",obj,function(data){
				data=1;
				if(data==1){		//验证成功执行这个
					//页面切换
					dierbu=true;  //防止直接控制第三页显示
					$(".center1").removeClass("active");
					$(".center2").addClass("active");
				}else{
					//验证码错误	
					alert("验证码错误，重新输入")
				}
			});				
		}
	}
})


//第三步  

$("#passWord1").focus(checkPwd);
$("#passWord1").keyup(checkPwd);
$("#passWord2").focus(checkPwd2);
$("#passWord2").keyup(checkPwd2);

	//密码验证函数
function checkPwd(e){
	var ev=window.event||e;
	var content=$("#passWord1").val();
	//	获取焦点的逻辑
	if(ev.type=="focus"){
		if(content.length==0){
			$(".c2_liss_pasd1 span").removeClass();
		}
		return false;
	}
	//	失去焦点逻辑
	if(ev.type=="keyup"){
		if(content.length==0){
			$(".c2_liss_pasd1 span").removeClass();
		}else{
			var reg=/^.{5,15}$/;
			var flag=reg.test(content);
			if(flag){
				$(".c2_liss_pasd1 span")[0].className="ok";
				return true;
			}else{
				$(".c2_liss_pasd1 span")[0].className="error";
			}
		}
		return false;
	}
	//	提交时逻辑
	if(content.length==0){
		$(".c2_liss_pasd1 span")[0].className="error";						
	}else{
		var reg=/^.{6,20}$/;
		var flag=reg.test(content);
		if(flag){
			$(".c2_liss_pasd1 span").className="ok";			
			return true;
		}else{
			$(".c2_liss_pasd1 span")[0].className="error";
		}
	}
	return false;
}	

	//	密码确认函数
function checkPwd2(e){
		var content2=$("#passWord2").val();
		var content=$("#passWord1").val();		
		var ev=window.event||e;
		if(ev.type=="focus"){
			if(content2.length==0){
				$(".c2_liss_pasd2 span").removeClass();
			}
			return false;
		}
		if(ev.type=="keyup"){
			if(content2.length==0){
				$(".c2_liss_pasd2 span").removeClass();
			}else{			
				if(content==content2){
					$(".c2_liss_pasd2 span")[0].className="ok";
					
					return true;
				}else{
					$(".c2_liss_pasd2 span")[0].className="error";			
				}
			}
			return false;
		}
		
		if(content2.length==0){
			$(".c2_liss_pasd2 span")[0].className("error");
		}else{			
			if(content==content2){
				$(".c2_liss_pasd2 span")[0].className="ok";
				return true;
			}else{
				$(".c2_liss_pasd2 span")[0].className="error";
			}			
		}
		return false;
	}
	
	//第三步提交逻辑
$(".c2_liss_wrap_tijiao").click(function(){
	if(diyibu&&dierbu){
		if(checkPwd()&&checkPwd2()){
				var obj={
				userName:$("#userName").val(),
				password:$("#passWord1").val()
			}
			//测试第三步提交逻辑
	
			$.get("register.html",obj,function(data){
				data=1;
				if(data==1){		//验证成功执行这个
					diyibu=false;  
					dierbu=false;
					$(".zhezhao").css("display","block");
					$(".zhezhao_bor").css("display","block");			
				}else{	
					alert("密码修改失败")
				}
			});
		}			
	}
})








