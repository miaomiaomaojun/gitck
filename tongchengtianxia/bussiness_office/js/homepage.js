$(document).ready(function() {
			/*日历插件js*/
			var $datepicker = $('#datepicker').pikaday({
				firstDay: 1,
				minDate: new Date('2000-01-01'),
				maxDate: new Date('2020-12-31'),
				yearRange: [2000, 2020],
				bound: false,
			});
		});
		/*滚动公告js*/
		var t = getid("notice"),
			t1 = getid("notice1"),
			t2 = getid("notice2"),
			sh = getid("show"),
			timer;
		t2.innerHTML = t1.innerHTML;
		function mar() {
			if(t2.offsetTop <= t.scrollTop)
				t.scrollTop -= t1.offsetHeight;
			else
				t.scrollTop++;
		}
		timer = setInterval(mar, 100);

		function getid(id) {
			return document.getElementById(id);
		};
		//限制字符个数
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