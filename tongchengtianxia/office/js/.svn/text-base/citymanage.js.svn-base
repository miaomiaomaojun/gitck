$(document).ready(function() {
/*顶部*/
	$('.arrow').toggle(function() {
		$(this).next("div").slideDown();
	}, function() {
		$(this).next("div").slideUp();
	})
	$("#hidebox ul li").click(function() {
		$(this).addClass("chg").siblings().removeClass("chg");
		$("#place").html($(this).html());
		$("#hidebox").slideUp();
		$(this).parents(".sm").next("div").find("p").html($(this).html());
	});
	$("#city ul li").click(function() {
		$(this).addClass("chg").siblings().removeClass("chg");
		$("#cityadd").html($(this).html());
		$("#cityadd").css("color", "#231815");
		$("#city").slideUp();
	});
	$("#area ul li").click(function() {
		$(this).addClass("chg").siblings().removeClass("chg");
		$("#areaadd").html($(this).html());
		$("#areaadd").css("color", "#231815");
		$("#area").slideUp();
	});
	
	/*打开隐藏盒子*/
	$(".kinds .checkboxarrow").toggle(function() {
		$(this).parent().next(".box_hide").slideDown();
	}, function() {
		$(this).parent().next(".box_hide").slideUp();
	});
	/*添加弹窗逻辑*/
	$('.addplace').click(function() {
		$('.zhezhao').show();
		$('.zhezhao_tianjia').show();
	})
	$('.zhezhao_close').click(function() {
		$('.zhezhao').hide();
		$('.zhezhao_tianjia').hide();
	})
	$("#parea ul li").click(function() {
		$("#prearea").css("color", "#231815");
		$("#prearea p").html($(this).html());
		$("#parea").slideUp();
		$(this).addClass('active').siblings().removeClass('active');
	});
	$("#submit").click(function() {
		var keyVal = $("#sqname").val();
		if(keyVal == "") {
			$("#alert").html("输入不能为空");
			$("#alert").show();
		} else {
			$("#alert").hide();
			var reg = /^[\u4e00-\u9fa5\da-zA-Z]+$/;
			if(!reg.test(keyVal)) {
				$("#alert").html("格式不正确");
				$("#alert").show();
			};
		};
		var paixu = $("#px").val();
		if(paixu == "") {
			$("#warning").html("输入不能为空");
			$("#warning").show();
		} else {
			$("#warning").hide();
			var reg = /^\d+$/;
			if(!reg.test(paixu)) {
				$("#warning").html("只能输入数字");
				$("#warning").show();
			};
		};

	});
	/*编辑弹窗*/
	$('.bianji').click(function() {
		$('.zhezhao').show();
		$('.zhezhao_bianji').show();
	})
	$('.zhezhao_close').click(function() {
		$('.zhezhao').hide();
		$('.zhezhao_bianji').hide();
	});
	$("#pareab ul li").click(function() {
	$("#preareab").css("color", "#231815");
	$("#preareab p").html($(this).html());
	$("#pareab").slideUp();
	$(this).addClass('active').siblings().removeClass('active');
});
$("#submitb").click(function() {
		var keyVal = $("#sqnameb").val();
		if(keyVal == "") {
			$("#alertb").html("输入不能为空");
			$("#alertb").show();
		} else {
			$("#alertb").hide();
			var reg = /^[\u4e00-\u9fa5\da-zA-Z]+$/;
			if(!reg.test(keyVal)) {
				$("#alertb").html("格式不正确");
				$("#alertb").show();
			};
		};
		var paixu = $("#paixub").val();
		if(paixu == "") {
			$("#warningb").html("输入不能为空");
			$("#warningb").show();
		} else {
			$("#warningb").hide();
			var reg = /^\d+$/;
			if(!reg.test(paixu)) {
				$("#warningb").html("只能输入数字");
				$("#warningb").show();
			};
		};

	});
/*判断是否推荐*/
	var pd = $(".rm p");
	$.each(pd, function(a, b) {
		if($(b).html() == "是") {
			$(this).css("color", "#ee9b26");
		};
	});
});