jQuery.extend({
    ValiformWidthTab: function (formId, layFilter) {
        if (typeof (formId) === 'undefined' || typeof (layFilter) === 'undefined') {
            return;
        }
        var layid = $(formId).find(".Validform_error:first").parents(".layui-tab-item").attr('layid');
        var li = $("li[lay-id='" + layid + "']").hasClass("layui-this");
        if (!li) {
            var element = layui.element;
            element.tabChange(layFilter, layid);
        }
    }
});

function launchFullscreen() {
    if ($("#tool_fullcreen").hasClass("show")) {
        $("#tool_fullcreen").removeClass("show");
    }
    $("#tool_fullcreen").addClass("hidden");
    if ($("#tool_exitfull").hasClass("hidden")) {
        $("#tool_exitfull").removeClass("hidden");
    }
    $("#tool_exitfull").addClass("show");
    var element = document.documentElement;
    // 判断各种浏览器，找到正确的方法
    var requestMethod = element.requestFullScreen || element.webkitRequestFullScreen || element.mozRequestFullScreen || element.msRequestFullscreen;
    if (requestMethod) {
        requestMethod.call(element);
    }
    else if (typeof window.ActiveXObject !== "undefined") {//for Internet Explorer
        var wscript = new ActiveXObject("WScript.Shell");
        if (wscript !== null) {
            wscript.SendKeys("{F11}");
        }
    }

}
function exitFull() {

    if ($("#tool_exitfull").hasClass("show")) {
        $("#tool_exitfull").removeClass("show");
    }
    $("#tool_exitfull").addClass("hidden");
    if ($("#tool_fullcreen").hasClass("hidden")) {
        $("#tool_fullcreen").removeClass("hidden");
    }
    $("#tool_fullcreen").addClass("show");
    // 判断各种浏览器，找到正确的方法
    var exitMethod = document.exitFullscreen || document.mozCancelFullScreen || document.webkitExitFullscreen || document.msExitFullscreen; //IE11msExitFullscreen	function msExitFullscreen() { [native code] }
    if (exitMethod) {
        exitMethod.call(document);
    }
    else if (typeof window.ActiveXObject !== "undefined") {//for Internet Explorer
        var wscript = new ActiveXObject("WScript.Shell");
        if (wscript !== null) {
            wscript.SendKeys("{F11}");
        }
    }

}

//初始化Tree目录结构
function initCategoryHtml(parentObj, layNum) {
    $(parentObj).find('li.layer-' + layNum).each(function (i) {
        var liObj = $(this);
        var nextNum = layNum + 1;
        if (liObj.next('.layer-' + nextNum).length > 0) {
            initCategoryHtml(parentObj, nextNum);
            var newObj = $('<ul></ul>').appendTo(liObj);
            moveCategoryHtml(liObj, newObj, nextNum);
        }
    });
}
function moveCategoryHtml(liObj, newObj, nextNum) {
    if (liObj.next('.layer-' + nextNum).length > 0) {
        liObj.next('.layer-' + nextNum).appendTo(newObj);
        moveCategoryHtml(liObj, newObj, nextNum);
    }
}

//全选取消按钮函数
function checkAll(chkobj) {
    if ($(chkobj).text() === "全选") {
        $(chkobj).children("span").text("取消");
        $("input[disabled!=disabled].checkall").prop("checked", true);
    } else {
        $(chkobj).children("span").text("全选");
        $("input[disabled!=disabled].checkall").prop("checked", false);
    }
}

//初始化Tree目录事件
$.fn.initCategoryTree = function (isOpen) {
    var fCategoryTree = function (parentObj) {
        //遍历所有的UL
        parentObj.find("ul").each(function (i) {
            //遍历UL第一层LI
            $(this).children("li").each(function () {
                var liObj = $(this);
                //判断是否有子菜单和设置距左距离
                var parentIconLenght = liObj.parent().parent().children(".tbody").children(".index").children(".icon").length; //父节点的左距离
                var indexObj = liObj.children(".tbody").children(".index"); //需要树型的目录列
                //设置左距离
                if (parentIconLenght === 0) {
                    parentIconLenght = 1;
                }
                for (var n = 0; n <= parentIconLenght; n++) { //注意<=
                    $('<i class="icon"></i>').prependTo(indexObj); //插入到index前面
                }

                //设置按钮和图标
                var icon = indexObj.children("a").attr("icon");
                if (icon.length > 0) {
                    if (icon.indexOf(".") === 0) {
                        icon = indexObj.children("a").attr("iconclass");
                        indexObj.children(".icon").last().addClass(icon);
                    }
                    else {
                        indexObj.children(".icon").last().append("<img src=\"" + icon + "\" width=\"14px\" style=\"display:block;\" />");
                    }
                }
                else {
                    indexObj.children(".icon").last().addClass("iconfont icon-news_hot_light"); //设置最后一个图标
                }

                //如果有下级菜单
                if (liObj.children("ul").length > 0) {
                    //如果要求全部展开
                    if (isOpen) {
                        indexObj.children(".icon").eq(-2).addClass("expandable iconfont icon-move"); //设置图标展开状态
                    } else {
                        indexObj.children(".icon").eq(-2).addClass("expandable iconfont icon-add1"); //设置图标闭合状态
                        liObj.children("ul").hide(); //隐藏下级的UL
                    }
                    //绑定单击事件
                    indexObj.children(".expandable").click(function () {
                        //如果菜单已展开则闭合
                        if ($(this).hasClass("icon-move")) {
                            //设置自身的右图标为+号
                            $(this).removeClass("icon-move");
                            $(this).addClass("icon-add1");
                            //隐藏自身父节点的UL子菜单
                            $(this).parent().parent().parent().children("ul").slideUp(300);
                        } else {
                            //设置自身的右图标为-号
                            $(this).removeClass("icon-add1");
                            $(this).addClass("icon-move");
                            //显示自身父节点的UL子菜单
                            $(this).parent().parent().parent().children("ul").slideDown(300);
                        }
                    });
                } else {
                    indexObj.children(".icon").eq(-2).addClass("iconfont icon-csac");
                }
            });
            //显示第一个UL
            if (i === 0) {
                $(this).show();
                //展开第一个菜单
                if ($(this).children("li").first().children("ul").length > 0) {
                    $(this).children("li").first().children(".tbody").children(".index").children(".expandable").removeClass("icon-add1");
                    $(this).children("li").first().children(".tbody").children(".index").children(".expandable").addClass("icon-move");
                    $(this).children("li").first().children("ul").show();
                }
            }
        });
    };
    return $(this).each(function () {
        fCategoryTree($(this));
    });
};

//写Cookie
function addCookie(objName, objValue, objHours) {
    var str = objName + "=" + escape(objValue);
    if (objHours > 0) {//为0时不设定过期时间，浏览器关闭时cookie自动消失
        var date = new Date();
        var ms = objHours * 3600 * 1000;
        date.setTime(date.getTime() + ms);
        str += "; expires=" + date.toGMTString();
    }
    document.cookie = str;
}

//读Cookie
function getCookie(objName) {//获取指定名称的cookie的值
    var arrStr = document.cookie.split("; ");
    for (var i = 0; i < arrStr.length; i++) {
        var temp = arrStr[i].split("=");
        if (temp[0] === objName) return unescape(temp[1]);
    }
    return "";
}
