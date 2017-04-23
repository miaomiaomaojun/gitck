function AJ(rdz, rml, rcallback, rsj, rdata) {
    var method = "GET"; if (!$_(rdata)) method = "POST"; if ($_(rdata)) rdata = null; if ($_(rsj)) rsj = null;
    rdz = rdz + ".aspx";
    XMLHttp.sendReq(method, rdz + "?" + rml, rdata, rcallback, rsj);
}
function $_(r) { return typeof r == "undefined"; }
function bmzd(r) { return encodeURIComponent(escape(r)); }

var XMLHttp = {
    _objPool: [], _jl: [],


    _getInstance: function () {
        var njs = 0;
        for (var i = 0; i < this._objPool.length; i++) {
            if (this._objPool[i].readyState == 0 || this._objPool[i].readyState == 4) {
                //if (parent.llq.ie6) { this._objPool[i] = this._createObj() }
                return this._objPool[i];
            } else { njs += 1; if (njs >= 1) { return null; } }
        }
        this._objPool[this._objPool.length] = this._createObj();

        return this._objPool[this._objPool.length - 1];
    },

    _createObj: function () {
        if (window.XMLHttpRequest) {
            var objXMLHttp = new XMLHttpRequest();
        }
        else {
            var MSXML = ['MSXML2.XMLHTTP.5.0', 'MSXML2.XMLHTTP.4.0', 'MSXML2.XMLHTTP.3.0', 'MSXML2.XMLHTTP', 'Microsoft.XMLHTTP'];
            for (var n = 0; n < MSXML.length; n++) {
                try {
                    var objXMLHttp = new ActiveXObject(MSXML[n]);
                    break;
                }
                catch (e) {
                }
            }
        }

        if (objXMLHttp.readyState == null) {
            objXMLHttp.readyState = 0;
            objXMLHttp.addEventListener("load", function () {
                objXMLHttp.readyState = 4;

                if (typeof objXMLHttp.onreadystatechange == "function") {
                    objXMLHttp.onreadystatechange();
                }
            }, false);
        }

        return objXMLHttp;
    },
    jczx: function () {
        if (XMLHttp._jl.length > 0) {
            var a = XMLHttp._jl.shift();
            XMLHttp.sendReq(a[0], a[1], a[2], a[3], a[4], a[5]);
        }
    },
    sendReq: function (method, url, data, callback, rsj) {
        var objXMLHttp = this._getInstance();
        if (!objXMLHttp) {
            if (this._jl.length > 5) { alert("提交次数过多，未能处理"); return; }
            this._jl.push([method, url, data, callback, rsj]); return;
        }
        try {
            objXMLHttp.onreadystatechange = function () {
                if (objXMLHttp.readyState == 4) {
                    var cwdm = objXMLHttp.status;
                    if (cwdm == 208) {
                        alert(objXMLHttp.responseText); XMLHttp.jczx(); return;

                    }
                    if (cwdm == 209) {
                        parent.eval(objXMLHttp.responseText); XMLHttp.jczx(); return;
                    }
                    if (cwdm == 200 || cwdm == 304) {
                        var fhsj = rsj ? [rsj, objXMLHttp.responseText] : objXMLHttp.responseText;
                        if (!!callback) callback(fhsj);

                        //if (objXMLHttp.responseText.length >= 1) {
                        //    var s1 = objXMLHttp.responseText.substr(0, 1);
                        //    if ("012".indexOf(s1) < 0) { alert("返回值有误"); XMLHttp.jczx(); return; }
                        //    var s2 = objXMLHttp.responseText.substr(1);
                        //    if (s1 == "2") {if(s2!="") parent.eval(s2); XMLHttp.jczx(); return; }
                        //    var fhsj = rsj ? [rsj, s2] : s2;
                        //    if (s1 != "1") { alert(s2); } else {if(!!callback) callback(fhsj); }
                        //} else {
                        //    alert("返回值有误:" + url);
                        //}
                    } else {
                        //为0时是读的本地缓存
                        if (objXMLHttp.status != 0) { alert("请求页面异常" + objXMLHttp.status); } else {
                            //alert("读取缓存，还未处理");
                        }
                    }

                    XMLHttp.jczx();
                }
            }
            objXMLHttp.open(method, url, true);
            objXMLHttp.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded; charset=UTF-8');
            objXMLHttp.send(data);
        }
        catch (e) {
            alert(e);
        }

        with (objXMLHttp) {

        }
    }
};