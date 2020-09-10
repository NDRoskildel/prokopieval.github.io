<?php include 'header1.php'; ?>

<?php include 'header2.php'; ?>


<script type="text/javascript">
//window.onload = function(){	calc();	}
	  
var var1 = 0; // тираж
var var2 = 0; // формат
var var3 = 0; // цветность
var var4 = 0; // бумага
var var5 = 0; // биговка
var var6 = 0; // качество
		

var color = '1+0';
var type = '90х100';
var paper = 'Простая';
var qual = 'Office Pro';
var k = 'на скобу';	
var big = '1 биг';
		
//тираж
function fnVar1(v1) {
	var cnt = 1;	
	var1 = v1;
	
	var result1 = document.getElementById("var1"); 
	
	result1.value  = var1;
	calc();
}

//цветность
function fnVar2(v2) {

	if (v2 === 1 ){color = '1+0'; var3 = v2; }
	if (v2 === 2 ){color = '1+1'; var3 = v2; }
	if (v2 === 3 ){color = '4+0'; var3 = v2; }
	if (v2 === 4 ){color = '4+4'; var3 = v2; }
		
	var result3 = document.getElementById("var3"); 
	result3.value = color;
	calc();
}



//формат
function fnVar3(v2) {

	if (v2 === 1 ){type = '90х100'; var2 = v2; }
	if (v2 === 2 ){type = '50х180'; var2 = v2; }
	if (v2 === 3 ){type = '90х150'; var2 = v2; }
	if (v2 === 4 ){type = '100х200'; var2 = v2; }
	
	if (v2 === 5 ){type = '100х400'; var2 = v2; }
	if (v2 === 6 ){type = 'А5'; var2 = v2; }
	if (v2 === 7 ){type = '105х297'; var2 = v2; }
	if (v2 === 8 ){type = '148х315'; var2 = v2; }
	
	if (v2 === 9 ){type = '150х440'; var2 = v2; }
	if (v2 === 10 ){type = 'А4'; var2 = v2; }
	if (v2 === 11 ){type = '148х420'; var2 = v2; }
	if (v2 === 12 ){type = 'А3'; var2 = v2; }
	
	var result2 = document.getElementById("var2"); 
	result2.value = type;
	calc();
}



//бумага
function fnVar4(v) {

	if (v === 1 ){paper = 'Простая'; var4 = v; }
	if (v === 2 ){paper = '90-130 г/м2'; var4 = v; }
	if (v === 3 ){paper = '150-170 г/м2'; var4 = v; }
	if (v === 4 ){paper = '180-200 г/м2'; var4 = v; }
	
	if (v === 5 ){paper = '210-230 г/м2'; var4 = v; }	
	if (v === 6 ){paper = '250-280 г/м2'; var4 = v; }
	if (v === 7 ){paper = '290-300 г/м2'; var4 = v; }
	if (v === 8 ){paper = '310-330 г/м2'; var4 = v; }
	
	var result4 = document.getElementById("var4"); 
	result4.value = paper;
	calc();
}




//биговка
function fnVar5(v) {
	if (v === 1 ){var5 = v; big = '1 биг'; }
	if (v === 2 ){var5 = v; big = '2 бига'; }
	if (v === 3 ){var5 = v; big = '3 бига'; }
	
	calc();
}		

//качество
function fnVar6(v) {
	if (v === 1 ){var6 = v; qual = 'Office Pro'; }
	if (v === 2 ){var6 = v; qual = 'Pro Plus'; }
	
	calc();
}		

function calc() {
	var res1 = 0;
	var res2 = 0;
	
	res1 = var2 + var3 + var4 + var5 + var6;
	res2 = var1 *(var2 + var3 + var4 + var5 + var6);
	
	var result1 = document.getElementById("varRes1"); 
	var result2 = document.getElementById("varRes2"); 
	
	result1.value  = res1;
	result2.value  = res2;	
	
	var resTxt = document.getElementById("txt"); 
	resTxt.value  = 'Буклеты. Количество: ' + var1 +' Формат: ' + type + ', Цветность  ' + color + ', Бумага: ' + paper +
		', Качество: ' + qual + ', Биговка: ' + big;	
		
}
	
</script>

<section id="serv">
	<div class="container">
		<div class="row  animated fadeInRight delay-0-1">
			<h1 class="title">Буклеты</h1>
			<h2 class="subtitle"></h2>

			<div class="col-md-12 col-sm-12">
				<p style="text-align: justify;"></p>				
			</div>
		</div>
		
		<div class="col-md-12 col-xl-12  animated fadeInRight delay-0-3">

			<legend>Форма заказа </legend>
			
			<form class="well form-horizontal" action="http://www.prostoysoft.ru/sendform.aspx?formtype=PsPrintFormBooklet" method="post"  id="contact_form">
			<fieldset>
					
			
			<div class="form-group">
				<div class="col-md-4"></div>
				
				<div class="col-md-4 inputGroupContainer">
					<div class="line"></div>
				</div>
			</div>


			<div class="form-group calc-group"> 				
				<div class="col-md-12 selectContainer">
					<div class="input-group">
						<table>							
							<tr>
								<td><input type="text" class="form-control res-control" id="var1" disabled ><p class="help-block">Тираж, шт.</p></td>
								<td><input type="text" class="form-control res-control" id="var2" disabled ><p class="help-block">Формат</p></td>
								<td><input type="text" class="form-control res-control" id="var3" disabled ><p class="help-block">Цветность</p></td>
								<td><input type="text" class="form-control res-control" id="var4" disabled ><p class="help-block">Бумага</p></td>
								<td><input type="text" class="form-control res-control" id="varRes1" disabled ><p class="help-block">Цена шт., руб.</p></td>
								<td style="vertical-align: baseline;padding-top: 5px;font-weight: bold;"><b>=</b> </td>
								<td><input type="text" class="form-control res-control" id="varRes2" disabled ><p class="help-block">Цена тиража</p></td>
							</tr>																
						</table>												
					</div>
				</div>

				<div class="col-md-6 selectContainer">
					<table class="tbl">
						<tr>
							<td colspan="8"><label>Тираж</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar1_01" onClick="fnVar1(1)" class="btn btn-default btn-sm">1</button></td>	
							<td><button type="button" id="btnVar1_02" onClick="fnVar1(5)"  class="btn btn-default btn-sm">5</button></td>
							<td><button type="button" id="btnVar1_03" onClick="fnVar1(10)"  class="btn btn-default btn-sm">10</button></td>
							<td><button type="button" id="btnVar1_04" onClick="fnVar1(50)"  class="btn btn-default btn-sm">50</button></td>							
						</tr>
						<tr>
							<td><button type="button" id="btnVar1_09" onClick="fnVar1(100)"  class="btn btn-default btn-sm">100</button></td>	
							<td><button type="button" id="btnVar1_10" onClick="fnVar1(200)"  class="btn btn-default btn-sm">200</button></td>
							<td><button type="button" id="btnVar1_11" onClick="fnVar1(300)"  class="btn btn-default btn-sm">300</button></td>
							<td><button type="button" id="btnVar1_12" onClick="fnVar1(400)"  class="btn btn-default btn-sm">400</button></td>							
						</tr>
						<tr>
							<td><button type="button" id="btnVar1_17" onClick="fnVar1(500)"  class="btn btn-default btn-sm">500</button></td>	
							<td><button type="button" id="btnVar1_18" onClick="fnVar1(600)"  class="btn btn-default btn-sm">600</button></td>
							<td><button type="button" id="btnVar1_19" onClick="fnVar1(700)"  class="btn btn-default btn-sm">700</button></td>
							<td><button type="button" id="btnVar1_20" onClick="fnVar1(800)"  class="btn btn-default btn-sm">800</button></td>							
						</tr>	
						<tr>
							<td><button type="button" id="btnVar1_17" onClick="fnVar1(900)"  class="btn btn-default btn-sm">900</button></td>	
							<td><button type="button" id="btnVar1_18" onClick="fnVar1(1000)"  class="btn btn-default btn-sm">1000</button></td>
							<td><button type="button" id="btnVar1_19" onClick="fnVar1(1500)"  class="btn btn-default btn-sm">1500</button></td>
							<td><button type="button" id="btnVar1_20" onClick="fnVar1(2000)"  class="btn btn-default btn-sm">2000</button></td>							
						</tr>						
					</table>

					
					<table class="tbl">
						<tr>
							<td colspan="8"><label>Цветность</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar2_01" onClick="fnVar2(1)"  class="btn btn-default btn-sm">1+0</button></td>	
							<td><button type="button" id="btnVar2_02" onClick="fnVar2(2)"  class="btn btn-default btn-sm">1+1</button></td>
							<td><button type="button" id="btnVar2_03" onClick="fnVar2(3)"  class="btn btn-default btn-sm">4+0</button></td>
							<td><button type="button" id="btnVar2_04" onClick="fnVar2(4)"  class="btn btn-default btn-sm">4+4</button></td>								
						</tr>							
					</table>						
				</div>	
				
				<div class="col-md-6 selectContainer">		
					<table class="tbl">
						<tr>
							<td colspan="5"><label>Формат</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(1)"  class="btn btn-default btn-sm">90х100</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(2)"  class="btn btn-default btn-sm">50х180</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(3)"  class="btn btn-default btn-sm">90х150</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(4)"  class="btn btn-default btn-sm">100х200</button></td>	
						</tr>
						<tr>
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(5)"  class="btn btn-default btn-sm">100х400</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(6)"  class="btn btn-default btn-sm">А5</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(7)"  class="btn btn-default btn-sm">105х297</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(8)"  class="btn btn-default btn-sm">148х315</button></td>	
						</tr>
						<tr>
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(9)"  class="btn btn-default btn-sm">150х440</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(10)"  class="btn btn-default btn-sm">А4</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(11)"  class="btn btn-default btn-sm">148х420</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(12)"  class="btn btn-default btn-sm">А3</button></td>	
						</tr>						
					</table>


					<table class="tbl">
						<tr>
							<td colspan="5"><label>Бумага</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar4_01" onClick="fnVar4(1)"  class="btn btn-default btn-sm">Простая</button></td>	
							<td><button type="button" id="btnVar4_02" onClick="fnVar4(2)"  class="btn btn-default btn-sm">90-130 г/м2</button></td>
							<td><button type="button" id="btnVar4_03" onClick="fnVar4(3)"  class="btn btn-default btn-sm">150-170 г/м2</button></td>
							<td><button type="button" id="btnVar4_04" onClick="fnVar4(4)"  class="btn btn-default btn-sm">180-200 г/м2</button></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar4_06" onClick="fnVar4(5)"  class="btn btn-default btn-sm">210-230 г/м2</button></td>	
							<td><button type="button" id="btnVar4_07" onClick="fnVar4(6)"  class="btn btn-default btn-sm">250-280 г/м2</button></td>
							<td><button type="button" id="btnVar4_08" onClick="fnVar4(7)"  class="btn btn-default btn-sm">290-300 г/м2</button></td>
							<td><button type="button" id="btnVar4_09" onClick="fnVar4(8)"  class="btn btn-default btn-sm">310-330 г/м2</button></td>
						</tr>						
					</table>

									
					<table class="tbl">
						<tr>
							<td colspan="8"><label>Биговка</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar7_01" onClick="fnVar5(1)"  class="btn btn-default btn-sm">1 биг</button></td>	
							<td><button type="button" id="btnVar7_01" onClick="fnVar5(2)"  class="btn btn-default btn-sm">2 бига</button></td>	
							<td><button type="button" id="btnVar7_01" onClick="fnVar5(3)"  class="btn btn-default btn-sm">3 бига</button></td>	
						</tr>					
					</table>	
						
					<table class="tbl">
						<tr>
							<td colspan="8"><label>Качество</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar7_01" onClick="fnVar6(1)"  class="btn btn-default btn-sm">Office Pro</button></td>	
							<td><button type="button" id="btnVar7_02" onClick="fnVar6(2)"  class="btn btn-default btn-sm">Pro Plus</button></td>						
						</tr>					
					</table>
					
				</div>				
				
			</div>			


			<div class="form-group">
			  <label class="col-md-4 control-label">Имя*</label>  
			  <div class="col-md-4 inputGroupContainer">
			  <div class="input-group">
			  <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
			  <input  id="fio" name="fio" placeholder="Ваше имя" class="form-control"  type="text" required >
				</div>
			  </div>
			</div>
			<div class="form-group">
			  <label class="col-md-4 control-label">E-Mail*	</label>  
				<div class="col-md-4 inputGroupContainer">
				<div class="input-group">
					<span class="input-group-addon"><i class="glyphicon glyphicon-envelope"></i></span>
			  <input id="e-mail" name="e-mail" placeholder="Ваш E-Mail" class="form-control"  type="text" required >
				</div>
			  </div>
			</div>			   
			<div class="form-group">
			  <label class="col-md-4 control-label">Телефон*</label>  
				<div class="col-md-4 inputGroupContainer">
				<div class="input-group">
					<span class="input-group-addon"><i class="glyphicon glyphicon-earphone"></i></span>
					<input id="phone" name="phone" placeholder="+7(999)123-45-67" class="form-control" type="text" required >
				</div>
			  </div>
			</div>
			<div class="form-group">
			  <label class="col-md-4 control-label">Сообщение</label>  
				<div class="col-md-4 inputGroupContainer">				
					<textarea id="txt" class="form-control" rows="5" col="8"></textarea>				
			  </div>
			</div>
			
			<div class="form-group">
				<div class="col-md-4"></div>
				
				<div class="col-md-4 inputGroupContainer">			
				  <div class="checkbox">
					<label> <input type="checkbox" data-error="Before you wreck yourself" required > Согласен на обработку персональных данных* </label>
				  </div>						
				</div>
			</div>
			
								
			<!-- Button -->
			<div class="form-group">
			  <label class="col-md-4 control-label"></label>
			  <div class="col-md-4" style="text-align: center;">
				<button type="submit" class="btn btn-warning" >Отправить <span class="glyphicon glyphicon-send"></span></button>
			  </div>
			</div>
			
			<div class="col-md-12 form-valid">*поля обязательны для заполнения</div>
			
			</fieldset>
			</form>

		
		</div>		
		
		
		
	</div>
</section>


<?php include 'footer.php'; ?>