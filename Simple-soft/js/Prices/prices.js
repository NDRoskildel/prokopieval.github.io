// изменение величин в таблице цен при изменении валюты
function ChangePriceCurrency() {
    var ddl, iIndex, tbl, dblKoef, row, cell, r, c, dblValue, y;
    ddl = document.getElementById('ddlCurrency');
    iIndex = ddl.selectedIndex;

    if (iIndex == 0) { // Российский рубль (RUR)
        dblKoef = 1;
    } else if (iIndex == 1) { // Доллар США (USD)
        dblKoef = 1 / 60;
    } else if (iIndex == 2) { // ЕВРО (EUR)
        dblKoef = 1 / 70;
    } else if (iIndex == 3) { // Украинская гривна (UAH)
        dblKoef = 1 / 2.1;
    } else if (iIndex == 4) { // Казахский тенге (KZT)
        dblKoef = 1 / 0.22;
    } else if (iIndex == 5) { // Белорусский рубль (BYR)
        dblKoef = 1 / 0.0034;
    }

    y = document.getElementById('tdYearlyService');
    
    dblValue = 2000; // parseInt(y.innerHTML);
    y.innerHTML = Math.round(dblValue * dblKoef) + ' в год';

    tbl = document.getElementById('tblPrices');
    for (var r = 1; r < tbl.rows.length; r++) { // cycle on rows
        row = tbl.rows[r];
        for (var c = 2; c < row.cells.length; c++) { // cycle on cells
            cell = row.cells[c];
            if (!isNaN(cell.innerHTML)) { // if numeric
                if (cell.title == '') {
                    dblValue = cell.innerHTML;
                    cell.title = dblValue; // save current value in rur
                } else {
                    dblValue = cell.title;
                    if (iIndex == 0) cell.title = '';
                }
                cell.innerHTML = Math.round(dblValue * dblKoef);
            }
        }
    }
}

// заполнение цены в форме оплаты через RBK money при выборе программы или лицензии
function FillPrice(ddlProgram, ddlLicense, txtPrice) {
    var iProgram, iLicense, sPrice, tbl;
    iProgram = ddlProgram.selectedIndex;
    iLicense = ddlLicense.selectedIndex;
    tbl = document.getElementById('tblPrices');
    if ((iProgram > 0) && (iLicense > 0)) {
        // if (iLicense < 5) {
        sPrice = tbl.rows[iProgram].cells[iLicense + 1].innerHTML;
        if (isNaN(sPrice)) {
            sPrice = 'впишите сумму';
        } else {
            sPrice = parseInt(sPrice);
        }
        txtPrice.value = sPrice;
    }
}

// заполнение способов оплаты в форме заказа при выборе программы или лицензии
function LicenseClick(ddlLicense, ddlPaymentType) {
    var iLicense = ddlLicense.selectedIndex;
    for (r = ddlPaymentType.options.length - 1; r >= 0; r--) {
        ddlPaymentType.remove(r); // remove all items
    }
    if (iLicense == 1) { // if БАЗОВАЯ
        ddlPaymentType.options[1] = new Option('Яндекс.Деньги', 'Яндекс.Деньги');
        ddlPaymentType.options[2] = new Option('WebMoney', 'WebMoney');
        ddlPaymentType.options[3] = new Option('RBK Money', 'RBK Money');
        ddlPaymentType.options[4] = new Option('Почтовый или телеграфный перевод', 'Почтовый или телеграфный перевод');
        ddlPaymentType.options[5] = new Option('По почте наложенным платежом', 'По почте наложенным платежом');
        ddlPaymentType.options[6] = new Option('Другой (укажите в комментариях)', 'Другой (укажите в комментариях)');
        ddlPaymentType.options[7] = new Option('Безналичный платеж без НДС', 'Безналичный платеж без НДС');
        ddlPaymentType.options[8] = new Option('Безналичный платеж с НДС', 'Безналичный платеж с НДС');
    } else { // if upper than БАЗОВАЯ
        ddlPaymentType.options[1] = new Option('Безналичный платеж без НДС', 'Безналичный платеж без НДС');
        ddlPaymentType.options[2] = new Option('Безналичный платеж с НДС', 'Безналичный платеж с НДС');
        ddlPaymentType.options[3] = new Option('Яндекс.Деньги', 'Яндекс.Деньги');
        ddlPaymentType.options[4] = new Option('WebMoney', 'WebMoney');
        ddlPaymentType.options[5] = new Option('RBK Money', 'RBK Money');
        ddlPaymentType.options[6] = new Option('Почтовый или телеграфный перевод', 'Почтовый или телеграфный перевод');
        ddlPaymentType.options[7] = new Option('По почте наложенным платежом', 'По почте наложенным платежом');
        ddlPaymentType.options[8] = new Option('Другой (укажите в комментариях)', 'Другой (укажите в комментариях)');
    }
}

// блокировка-разблокировка полей с реквизитами огранизации в зависимости от способа оплаты
function ddlPaymentType_onchange(ddlPaymentType) {
    var sPaymentType, sDis, sColor;
    sPaymentType = ddlPaymentType.children[ddlPaymentType.selectedIndex].innerHTML;
    if ((sPaymentType == 'Безналичный платеж с НДС') || (sPaymentType == 'Безналичный платеж без НДС')) {
        sDis = '';
        sColor = '';
    } else {
        sDis = 'disabled';
        sColor = 'Gray';
    }
    document.getElementById('RS').disabled = sDis; document.getElementById('tdRS').style.color = sColor;
    document.getElementById('Bank').disabled = sDis; document.getElementById('tdBank').style.color = sColor;
    document.getElementById('KS').disabled = sDis; document.getElementById('tdKS').style.color = sColor;
    document.getElementById('BIC').disabled = sDis; document.getElementById('tdBIC').style.color = sColor;
    document.getElementById('INN').disabled = sDis; document.getElementById('tdINN').style.color = sColor;
    document.getElementById('KPP').disabled = sDis; document.getElementById('tdKPP').style.color = sColor;
    document.getElementById('Address').disabled = sDis; document.getElementById('tdAddress').style.color = sColor;
    document.getElementById('Address2').disabled = sDis; document.getElementById('tdAddress2').style.color = sColor;
    document.getElementById('Address3').disabled = sDis; document.getElementById('tdAddress3').style.color = sColor;
    document.getElementById('DocBeforePay').disabled = sDis;
}

function Address2_onfocus() {
    if (document.getElementById('Address2').value == '') {
        document.getElementById('Address2').value = document.getElementById('Address').value;
    }
}

function Address3_onfocus() {
    if (document.getElementById('Address3').value == '') {
        if (document.getElementById('Address2').value > '') { document.getElementById('Address3').value = document.getElementById('Address2').value; }
        if (document.getElementById('Address').value > '') { document.getElementById('Address3').value = document.getElementById('Address').value; }
    }
}

// 
function ddlSource_onchange() {
    var ddlSource = document.getElementById('ddlSource');
    var txtOtherSource = document.getElementById('txtOtherSource');
    if (ddlSource.selectedIndex == ddlSource.options.length - 1) { // if Другое selected
        txtOtherSource.style.visibility = '';
    } else {
        txtOtherSource.style.visibility = 'hidden';
    }
}

// сабмит формы RBK
function CheckOnSubmitRbkOrQiwi(ddlProgram, ddlLicense, txtPrice) {
    if (ddlProgram.selectedIndex < 1) { alert('Заполните поле "Название программы"!'); ddlProgram.focus(); return false }
    if (ddlLicense.selectedIndex < 1) { alert('Заполните поле "Тип лицензии"!'); ddlLicense.focus(); return false }
    if (txtPrice.value == '') { alert('Заполните поле "Стоимость лицензии в рублях"!'); txtPrice.focus(); return false }
    if (confirm("Отправить форму?")) return true; // confirmation
    return false;
}

// сабмит формы заказа
function CheckOnSubmitOrder() {
    var txtClientEmail = document.getElementById('txtClientEmail');
    var ddlProgram = document.getElementById('ddlProgram');
    var ddlLicense = document.getElementById('ddlLicense');
    var ddlPaymentType = document.getElementById('ddlPaymentType');
    if (txtClientEmail.value == '') { alert('Заполните поле "Эл. почта"!'); txtClientEmail.focus(); return false }
    if (ddlProgram.selectedIndex < 1) { alert('Заполните поле "Программа"!'); ddlProgram.focus(); return false }
    if (ddlLicense.selectedIndex < 1) { alert('Заполните поле "Тип лицензии"!'); ddlLicense.focus(); return false }
    if (ddlPaymentType.selectedIndex < 1) { alert('Заполните поле "Способ оплаты"!'); ddlPaymentType.focus(); return false }
    if (confirm("Отправить форму?")) return true; // confirmation
    return false;
}

// заполнение формы Qiwi
function FillQiwiCommentAndPrice() {
    var ddlProgramQ, ddlLicenseQ, txtPriceQ, txtEmailQ, txtNameQ, ddlCommentQ, sPrice, sProgram, sLicense, sEmail, sName, sComments;

    ddlProgramQ = document.getElementById('ddlProgramQ');
    ddlLicenseQ = document.getElementById('ddlLicenseQ');
    txtPriceQ = document.getElementById('amount_rub');
    ddlCommentQ = document.getElementById('com');
    txtEmailQ = document.getElementById('txtEmailQ');
    txtNameQ = document.getElementById('txtNameQ');

    sPrice = GetPrice(ddlProgramQ.selectedIndex, ddlLicenseQ.selectedIndex);
    sProgram = ddlProgramQ.children[ddlProgramQ.selectedIndex].innerHTML;
    sLicense = ddlLicenseQ.children[ddlLicenseQ.selectedIndex].innerHTML;
    sEmail = txtEmailQ.value;
    sName = txtNameQ.value;

    sComments = sProgram + ' ' + sLicense; // + ' Email: ' + sEmail + ' FIO: ' + sName;

    txtPriceQ.value = sPrice;
    ddlCommentQ.value = sComments;
}

function GetPrice(iProgram, iLicense) {
    var sPrice = '', tbl;
    tbl = document.getElementById('tblPrices');
    if ((iProgram > 0) && (iLicense > 0)) {
        // if (iLicense < 5) {
        sPrice = tbl.rows[iProgram].cells[iLicense + 1].innerHTML;
        if (isNaN(sPrice)) {
            sPrice = 'впишите сумму';
        } else {
            sPrice = parseInt(sPrice);
        }
    }
    return sPrice;
}

function SetSelectedIndex(sID, iSelectedIndex) {
    var oControl;
    oControl = document.getElementById(sID);
    oControl.selectedIndex = iSelectedIndex;
}

// Qiwi

var ie = document.all;
var moz = (navigator.userAgent.indexOf("Mozilla") != -1);
var opera = window.opera;
var brodilka = "";
if (ie && !opera) { brodilka = "ie"; }
else if (moz) { brodilka = "moz"; }
else if (opera) { brodilka = "opera"; }
var inputMasks = new Array();

function kdown(inpt, ev) {
    var id = inpt.getAttribute("id");
    var idS = id.substring(0, id.length - 1);
    var idN = Number(id.substring(id.length - 1));
    inputMasks[idS].BlKPress(idN, inpt, ev);
}

function kup(inpt, ck) {
    if (Number(inpt.getAttribute("size")) == inpt.value.length) {
        var id = inpt.getAttribute("id");
        var idS = id.substring(0, id.length - 1);
        var idN = Number((id.substring(id.length - 1))) + 1;
        var t = document.getElementById(idS + idN);
        if (ck != 8 && ck != 9) {
            if (t) { t.focus(); }
        } else if (ck == 8) {
            inpt.value = inpt.value.substring(0, inpt.value.length - 1);
        }
    }
}

function Mask(fieldObj) {
    var template = "(\\d{3})\\d{3}-\\d{2}-\\d{2}";
    var parts = [];
    var blocks = [];
    var order = [];
    var value = "";

    var Block = function (pattern) {
        var inptsize = Number(pattern.substring(3, pattern.indexOf('}')));
        var idS = fieldObj.getAttribute("id");
        var idN = blocks.length;
        var text = "";

        var checkKey = function (ck) {
            return ((ck >= 48) && (ck <= 57)) || ((ck >= 96) && (ck <= 105)) || (ck == 27) || (ck == 8) || (ck == 9) || (ck == 13) || (ck == 45) || (ck == 46) || (ck == 144) || ((ck >= 33) && (ck <= 40)) || ((ck >= 16) && (ck <= 18)) || ((ck >= 112) && (ck <= 123));
        }

        this.makeInput = function () {
            return "<input type='text' " + "size='" + inptsize + "' maxlength='" + inptsize + "'" + " id='" + idS + idN + "' onKeyDown='kdown(this, event)' onKeyUp='kup(this, event.keyCode)' value='" + text + "'>";
        }

        this.key = function (inpt, ev) {
            if (opera) return;
            if (!checkKey(ev.keyCode)) {
                switch (brodilka) {
                    case "ie":
                        ev.cancelBubble = true;
                        ev.returnValue = false;
                        break;
                    case "moz":
                        ev.preventDefault();
                        ev.stopPropagation();
                        break;
                    case "opera":
                        break;
                    default:
                }
                return;
            }

            if (ev.keyCode == 8 && inpt.value == "") {
                var tid = inpt.getAttribute("id");
                var tidS = tid.substring(0, tid.length - 1);
                var tidN = Number(tid.substring(tid.length - 1)) - 1;
                var t = document.getElementById(tidS + tidN);
                if (t != null) t.focus();
            }
        }

        this.getText = function () {
            text = document.getElementById(idS + idN).value;
            return text;
        }

        this.setText = function (val) {
            text = val;
        }

        this.getSize = function () {
            return inptsize;
        }
    }

    this.drawInputs = function () {
        var inputStr = "<span class='Field'>";
        var p = 0;
        var b = 0;
        for (var i = 0; i < order.length; i++) {
            if (order[i] == "p") {
                inputStr += parts[p];
                p++;
            } else {
                inputStr += blocks[b].makeInput();
                b++;
            }
        }
        inputStr += "</span>";
        document.getElementById("div_" + fieldObj.getAttribute("id")).innerHTML = inputStr;
        fieldObj.style.display = "none";
    }

    this.buildFromFields = function () {// constructor
        var tmpstr = template;
        while (tmpstr.indexOf("\\") != -1) {
            var slash = tmpstr.indexOf("\\");
            var d = "";
            if (tmpstr.substring(0, slash) != "") {
                parts[parts.length] = tmpstr.substring(0, slash);
                order[order.length] = 'p';
                tmpstr = tmpstr.substring(slash);
            }
            var q = tmpstr.indexOf('}');
            blocks[blocks.length] = new Block(tmpstr.substring(0, q + 1), d);
            tmpstr = tmpstr.substring(q + 1);
            order[order.length] = 'b';
        }
        if (tmpstr != "") {
            parts[parts.length] = tmpstr;
            order[order.length] = 'p';
        }
        this.drawInputs();
    }

    this.buildFromFields();

    this.BlKPress = function (idN, inpt, ev) {
        blocks[idN].key(inpt, ev);
    }

    this.makeHInput = function () {
        var name = fieldObj.getAttribute("name");
        document.getElementById("div_" + fieldObj.getAttribute("id")).innerHTML =
        "<input type='text' readonly='readonly' name='" + name + "' value='" + this.getValue() + "'>";
    }

    this.getFName = function () {
        return fieldObj.getAttribute("name");
    }

    this.getValue = function () {
        value = "";
        var p = 0;
        var b = 0;
        for (var i = 0; i < order.length; i++) {
            if (order[i] != 'p') {
                value += blocks[b].getText();
                b++;
            }
        }
        return value;
    }

    this.check = function () {
        for (var i in blocks) {
            if (blocks[i].getText().length == 0) return false;
        }
        return true;
    }
}