var _hmt = _hmt || [];
$(function(){ 
	$('#regist').on('click', function(){
			layer.open({
			type: 2, //2 iframe层
			title: '欢迎注册',
			area:['430px','360px'],
			content: 'http://ask.com/member.php?act=regist' //这里content是一个URL，如果你不想让iframe出现滚动条，你还可以content: ['http://sentsin.com', 'no']
		  }); 
		});
	$('#loginReturn').on('click', function(){
		layer.open({
		type: 2, //2 iframe层
		title: '登录',
		area:['430px','360px'],
		content: 'http://ask.com/member.php?act=login' //这里content是一个URL，如果你不想让iframe出现滚动条，你还可以content: ['http://sentsin.com', 'no']
	  }); 
	});
	$('#complain').on('click', function(){
		layer.open({
		type: 2, //2 iframe层
		title: '反馈',
		area:['430px','360px'],
		content: 'http://ask.com/index.php?act=complain' //这里content是一个URL，如果你不想让iframe出现滚动条，你还可以content: ['http://sentsin.com', 'no']
	  }); 
	});
	$('#search').on('click', function(){
		var search_input = $("#search_input").val();
		if(search_input==""){
		}else{
			search_input = encodeURIComponent(search_input);
			top.location='/s/'+search_input;
		}
		return false;
	});
	document.onkeydown = function(e){ 
	    var ev = document.all ? window.event : e;
	    if(ev.keyCode==13) {
	    	var search_input = $("#search_input").val();
			if(search_input==""){
			}else{
				search_input = encodeURIComponent(search_input);
				top.location='/s/'+search_input;
			}
			return false;
	     }
	}
	
	var hm = document.createElement("script");
	  hm.src = "https://hm.baidu.com/hm.js?82cf154d3fe0d815847ee595230f01c1";
	  var s = document.getElementsByTagName("script")[0]; 
	  s.parentNode.insertBefore(hm, s);

	    var bp = document.createElement('script');
	    var curProtocol = window.location.protocol.split(':')[0];
	    if (curProtocol === 'https') {
	        bp.src = 'https://zz.bdstatic.com/linksubmit/push.js';        
	    }
	    else {
	        bp.src = 'http://push.zhanzhang.baidu.com/push.js';
	    }

		
		
		
	function t(e) {
        var t = window.location.href,
        n = t.split("").reverse(),
        r = e.split(""),
        i = [];
        for (var s = 0,
        o = 16; s < o; s++) i.push(r[s] + (n[s] || ""));
        var str = i.join("");
		return str;
    }
	 
    var n = /([http|https]:\/\/[a-zA-Z0-9\_\.]+\.so\.com)/gi,
    r = window.location.href;
    if (r && !n.test(r) && window.navigator.appName) {
        var i = "//s.360.cn/so/zz.gif",
        o = 'd55986f8cf52771f7d4100edc18b31cd',
        u = t(o),
        a = new Image;
        r && (i += "?url=" + encodeURIComponent(r)),
        o && (i += "&sid=" + o),
        u && (i += "&token=" + u),
        o && (a.src = i)
    }
//    $(".footer").append('<iframe id="union" src="https://www.doc88.com/?scode=206994974" width="0" height="0" style="display:none;"></iframe>');
});

