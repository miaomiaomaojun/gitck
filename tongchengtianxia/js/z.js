function AJ(rdz, rml, rcallback, rsj, rdata, rerrcl) {
    var method = "GET"; if (!$_(rdata)) method = "POST"; if ($_(rdata)) rdata = null; if ($_(rsj)) rsj = null; if ($_s(rcallback)) rcallback = null;
    if (!$_s(rml)) rml = ""; if (rml != "") rml = "&" + rml;
    rdz = "/cx_ph/" + rdz + ".aspx?dlmc=" + _Cz.dlmc + rml;
    Isj.XMLHttp.sendReq(method, rdz, rdata, rcallback, rsj, rerrcl);
    //监控
    //var dz1 = "http://y.ys168.com:8032/cx/" + rdz;
    //ts1.innerHTML = "<a href='" + dz1 + "' target=_blank>" + dz1 + "</a><br>" + ts1.innerHTML;
}


function $i(id, rhtml) {
    if ($_s(rhtml)) { $id(id).innerHTML = rhtml; return; } return $id(id).innerHTML;
}
function $a(ro, attName, attValue) {

    if ($_(attName)) attName = "d"; attName = "data-" + attName;
    if (!$_(attValue)) { ro.setAttribute(attName, attValue); return; }
    return ro.getAttribute(attName);
}
function $id(id) {
    if (typeof (id) != "string") return id; return document.getElementById(id);
}
function vre(z1, z2, z3) { jgzz = z1.replace(new RegExp(z2, "g"), z3); return jgzz; }
function $_(r) { return typeof r == "undefined"; }
function $_s(r) { return typeof r == "string"; }
function $c(ro, claName, kg) {
    //无值判断 ；1.增加；0,删除；2，更换
    if ($_s(ro)) ro = $id(ro); if (!ro) { alert("$c(),目标不存在") };
    if ($_(claName)) return ro.className; var c1 = " " + ro.className + " "; var cz = (c1.indexOf(" " + claName + " ") >= 0);
    if ($_(kg)) return cz; if (kg == 2) kg = cz ? 0 : 1;
    if (!kg) { if (cz) { c1 = vre(c1, " " + claName + " ", ""); ro.className = $trim(c1); } return 0; }
    if (!cz) { c1 = ro.className + " " + claName; ro.className = $trim(c1); } return 1;
}
function $k(ro, kg) {
    if ($_(kg)) return !$c(ro, "g");
    if (kg) $c(ro, "g", 0); else $c(ro, "g", 1);
    //if (kg) ro.style.display = "block"; else ro.style.display = "none";
}
var $b = function (ro, kg) { if ($_(kg)) return ro.disabled; if (kg) ro.removeAttribute('disabled'); else ro.disabled = 'false'; }
var $e = function (rq, f) { for (var i = 0; i < rq.length; i++) { if (f.call(rq[i])) { return i; break; } } return -1; }
var $bm = function (r) { return encodeURIComponent(escape(r)); }
var $jm = function (r) { return unescape(decodeURIComponent(r)); }

var $tn = function (r) { return r.tagName.toLowerCase(); }
var $trim = function (r) { return r.replace(/(^\s*)|(\s*$)/g, ""); }



//============================
//窗口代码


var _llq = {  //浏览器信息

    w: function () { return document.documentElement.clientWidth; }
    , h: function () { return document.documentElement.clientHeight; }
    , u: function () { return navigator.userAgent.toLowerCase(); }
    , ff: function () { return this.u().indexOf("firefox") >= 0; }
    , gg: function () { return this.u().indexOf("chrome") >= 0; }
    , ie: function () { return (this.u().indexOf("msie") >= 0 || this.u().indexOf("trident") > 0); }
    , b: function () {
        if (this.u().indexOf("msie 6.0") >= 0) { return 6; }
        if (this.u().indexOf("msie 7.0") >= 0) { return 7; }
        if (this.u().indexOf("msie 8.0") >= 0) { return 8; }
        if (this.u().indexOf("trident") > 0) { return 10 }
        return 9;
    }
};



var _CK = {
    cs: {

        //w: 400            //宽度可以不设置【默认90%宽度】
        w_max: 600           //最大宽度
        , h: 200             //默认值260
        , size: 1            //窗口是否支持缩放【默认值：不支持】
        , v: "4.1"           //版本号，用于刷新窗口，高度或发布时用
        , bjs: "yellow"       //背景色

    }


};
var _C = {
   mrbjs: "#FFFFE6",//默认背景色
    z: 1000, t: function () { _C.z += 1; return _C.z }, zd: function (rmc) { if (_CK[rmc].ck.style.zIndex < _C.z) { _CK[rmc].ck.style.zIndex = _C.t(); } },
    dxcl: function (r) {
        if (!r.h) { r.h = 260; }
        if (!r.w || r.w > _llq.w()) { r.w = parseInt(_llq.w() * 0.9); };
        if (r.w_max && r.w > r.w_max) { r.w = r.w_max; };
        if (r.h > _llq.h()) { r.h = _llq.h; }
        if (!r.bjs) r.bjs = "#FFFFE6";
    },
    kq: function (r, r1) {
        if ($_s(r)) { var x = r; r = _CK[x]; r.mc = x; } else { alert("不再支持直接调用"); return; }
        r.z = r1;
        if (!r.zt) { r.zt = true; this.dxcl(r); this.qd(r); this.jz(r); } else {
            this.cx(r);
            if (!r.zdnr) { r.ct().csdy(); } else {
                if (r.nr.substr(0, 4) == "http") {
                    //self.frames[r.id + "_i"].src = r.nr;
                    r.ck.childNodes[1].innerHTML = "";
                    this.xr(r);
                }
            }

        }
    },
    qd: function (r) {
        r.id = "D_" + r.mc; r.zdnr = $_s(r.nr) ? 1 : 0; r.ct = function () { return self.frames[r.id + "_i"] };
        var s1 = "<div id='" + r.id + "' class='ck' style='width:" + r.w + "px;left:180px;top:150px;display:none;"
        s1 += "background-color:" + ((r.bjs) ? r.bjs : _C.mrbjs) + "';>";
        s1 += "<div class='ckbt'><a href='javascript:' onclick='this.focus();_CK." + r.mc + ".gb()' class='abu'><i class='icon iconfont' style='font-size:22px;'>&#xe626;</i></a><label>" + (r.bt ? r.bt : "") + "</label></div>";
        s1 += "<div" + (r.h == 0 ? "" : " style='height:" + r.h + "px;'") + "></div>";
        if (r.size) { s1 += "<div style='height:12px;cursor:nw-resize;background-color:" + ((r.bjs) ? r.bjs : _C.mrbjs) + ";'><div class='rrr'></div></div>" };
        s1 += "</div>";
        var e1 = document.createElement('div'); document.body.appendChild(e1); e1.innerHTML = s1; r.ck = document.body.lastChild.childNodes[0];
        this.xr(r);
        //手机版的可以不用拖动
        drag(r.ck.childNodes[0], r.ck, true, (!!r.zdnr));
        if (r.size) drag(r.ck.lastChild, r.ck.childNodes[1], false, (!!r.zdnr)); r.ck.childNodes[1].onmousedown = function () { if (r.ck.style.zIndex < _C.z) { r.ck.style.zIndex = _C.t(); } };
        if (!r.gb) r.gb = function () { r.ck.style.display = "none"; };
    },
    xr: function (r) {
        if (r.zdnr && r.nr.substr(0, 4) != "http") { r.ck.childNodes[1].innerHTML = r.nr; } else {
            var ir1 = document.createElement('iframe'); ir1.name = r.id + "_i"; ir1.id = r.id + "_i";
            if (r.zdnr && r.nr.substr(0, 4) == "http") {
                ir1.src = r.nr;
            } else {
                ir1.src = _Cz .zydz + "ck/" + r.mc + ".html" + ((r.v) ? "?" + r.v : "");
            }
            ir1.setAttribute("frameborder", "0", 0);
            r.ck.childNodes[1].appendChild(ir1);
        }
    },
    xs: function (r) { if (r.ck.style.zIndex < _C.z) r.ck.style.zIndex = _C.t(); if (r.ck.style.display == "none") { r.ck.style.display = "block"; } },
    jz: function (r) {
        if (r.wz) { r.ck.style.left = r.wz[0] + "px"; r.ck.style.top = r.wz[1] + "px"; this.xs(r); return; };
        var x1 = parseInt(_llq.w() / 2 - parseInt(r.ck.style.width) / 2);
        var y1 = parseInt(_llq.h() / 3 - parseInt(r.ck.childNodes[1].style.height) / 2);
        if (y1 < 0) y1 = 0; if (x1 < 0) x1 = 0;
        r.ck.style.left = x1 + "px"; r.ck.style.top = y1 + "px";
        this.xs(r);
    },
    cx: function (r) {
        if (r.wz && !r.wz[2]) { _C.jz(r); return; }
        //var w1 = parseInt(r.ck.style.width) / 3;
        // var h1 = parseInt(r.ck.childNodes[1].style.height) / 3;
        var w1 = parseInt(r.ck.offsetWidth) / 3;
        var h1 = parseInt(r.ck.offsetHeight) / 3;
        var l1 = parseInt(r.ck.style.left);
        var t1 = parseInt(r.ck.style.top);

        if (l1 > (_llq.w() - w1)) { this.jz(r); return; };
        if (t1 > (_llq.h() - h1)) { this.jz(r); return; };
        this.xs(r);
    },
    bt: function (rmc, rbt) { _CK[rmc].ck.childNodes[0].childNodes[1].innerHTML = rbt; }
};
function drag(o, omb, isyd, ctpd) {
    o.onmousedown = function (a) {
        if (isyd) { if (omb.style.zIndex < _C.z) { omb.style.zIndex = _C.t(); } };
        var d = document; if (!a) a = window.event; var x_ = a.clientX; var y_ = a.clientY; var x0; var y0;
        if (isyd) {
            x0 = parseInt(omb.style.left); y0 = parseInt(omb.style.top);
        } else {
            x0 = parseInt(omb.parentNode.style.width); y0 = parseInt(omb.style.height);
        };
        if (!_llq.gg()) {
            if (o.setCapture) { o.setCapture(); } else if (window.captureEvents) { window.captureEvents(Event.MOUSEMOVE | Event.MOUSEUP); };
        }
        if (_llq.gg() && !ctpd) {
            //var ox = o.parentNode.childNodes[1].childNodes[0]; if (ox.style.display != "none") ox.style.display = "none";
        }
        d.onmousemove = function (a) {
            if (!a) a = window.event;
            var x1 = x0 + (a.clientX - x_); var y1 = y0 + (a.clientY - y_);
            x1 = (x1 < 0) ? 0 : x1; y1 = (y1 < 0) ? 0 : y1;
            if (isyd) {
                if (y1 < 22) y1 = 22;
                omb.style.left = x1 + "px"; omb.style.top = y1 + "px";
            } else {
                if (x1 < 60) x1 = 60; if (y1 < 40) y1 = 40;
                omb.parentNode.style.width = x1 + "px"; omb.style.height = y1 + "px";
            };

        };
        d.onmouseup = function () {
            //if (llq.gg && !ctpd) { o.parentNode.childNodes[1].childNodes[0].style.display = "block"; }
            if (!_llq.gg()) { if (o.releaseCapture) { o.releaseCapture(); } else if (window.captureEvents) { window.captureEvents(Event.MOUSEMOVE | Event.MOUSEUP); }; }
            d.onmousemove = null; d.onmouseup = null;
        };
        return false;

    }
}

//============================
//窗口代码结束