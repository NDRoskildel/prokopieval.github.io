<?php include 'header1.php'; ?>

<?php include 'header2.php'; ?>


<script type="text/javascript">
window.onload = function(){	calc();	}
	  
var var1 = 0; // тираж
var var2 = 0; // формат
var var3 = 0; // цветность вн. блока
var var4 = 0; // бумага обложки
var var5 = 0; // бумага вн. блока
var var6 = 0; // цветность обложки
var var7 = 0; // качество
var var8 = 0; // крпление
var var9 = 0; // количество полос


var color = '1+0';
var color2 = '1+0';
var type = '50х50';
var paper = 'Простая';
var paper2 = 'Простая';
var qual = 'Office Pro';
var k = 'на скобу';	


	
	
//тираж
function fnVar1(v1) {
	var cnt = 1;	
	var1 = v1;
	
	var result = document.getElementById("var1"); 
	
	result.value  = var1;
	calc();
}

//цветность обложки
function fnVar2(v2) {

	if (v2 === 1 ){color = '1+0'; var3 = v2; }
	if (v2 === 2 ){color = '1+1'; var3 = v2; }
	if (v2 === 3 ){color = '4+0'; var3 = v2; }
	if (v2 === 4 ){color = '4+4'; var3 = v2; }
		
	var result = document.getElementById("var6"); 
	result.value = color;
	calc();
}


//формат
function fnVar3(v2) {

	if (v2 === 1 ){type = '50х50'; var2 = v2; }
	if (v2 === 2 ){type = '100х100'; var2 = v2; }
	if (v2 === 3 ){type = 'А6'; var2 = v2; }
	if (v2 === 4 ){type = 'Евро'; var2 = v2; }
	
	if (v2 === 5 ){type = '150х150'; var2 = v2; }
	if (v2 === 6 ){type = 'А5'; var2 = v2; }
	if (v2 === 7 ){type = '100х300'; var2 = v2; }
	if (v2 === 8 ){type = '210х210'; var2 = v2; }
	
	if (v2 === 9 ){type = 'А4'; var2 = v2; }
	
	var result2 = document.getElementById("var2"); 
	result2.value = type;
	calc();
}



//цветность вн. блока
function fnVar4(v2) {
	
	if (v2 === 1 ){color2 = '1+0'; var3 = v2; }
	if (v2 === 2 ){color2 = '1+1'; var3 = v2; }
	if (v2 === 3 ){color2 = '4+0'; var3 = v2; }
	if (v2 === 4 ){color2 = '4+4'; var3 = v2; }
		
	var result = document.getElementById("var3"); 
	result.value = color2;
	calc();
}

//бумага обложки
function fnVar5(v) {
		
	if (v === 1 ){paper = 'Простая'; var4 = v; }
	if (v === 2 ){paper = '90-130 г/м2'; var4 = v; }
	if (v === 3 ){paper = '150-170 г/м2'; var4 = v; }
	if (v === 4 ){paper = '180-200 г/м2'; var4 = v; }
	
	if (v === 5 ){paper = '210-230 г/м2'; var4 = v; }	
	if (v === 6 ){paper = '250-280 г/м2'; var4 = v; }
	if (v === 7 ){paper = '290-300 г/м2'; var4 = v; }
	if (v === 8 ){paper = '310-330 г/м2'; var4 = v; }
	
	var result = document.getElementById("var7"); 
	result.value = paper;
	calc();
}

//бумага вн. блока
function fnVar6(v) {

	if (v === 1 ){paper2 = 'Простая'; var5 = v; }
	if (v === 2 ){paper2 = '90-130 г/м2'; var5 = v; }
	if (v === 3 ){paper2 = '150-170 г/м2'; var5 = v; }
	if (v === 4 ){paper2 = '180-200 г/м2'; var5 = v; }
	
	if (v === 5 ){paper2 = '210-230 г/м2'; var5 = v; }	
	if (v === 6 ){paper2 = '250-280 г/м2'; var5 = v; }
	if (v === 7 ){paper2 = '290-300 г/м2'; var5 = v; }
	if (v === 8 ){paper2 = '310-330 г/м2'; var5 = v; }
	
	var result = document.getElementById("var4"); 
	result.value = paper2;
	calc();
}


//качество
function fnVar7(v) {
	if (v === 1 ){var7 = v; qual = 'Office Pro'; }
	if (v === 2 ){var7 = v; qual = 'Pro Plus'; }
	
	calc();
}		


//крепление
function fnVar8(v) {
	
	if (v === 1 ){k = 'на скобу'; var8 = v; }
	if (v === 2 ){k = 'на пружину'; var8 = v; }
	if (v === 3 ){k = 'на клей'; var8 = v; }
	
	var result = document.getElementById("var8"); 
	result.value = k;
	
	calc();
}		


//количество полос
function fnVar9(v) {
	var cnt = 2;	
	var9 = v;
	
	var result = document.getElementById("var5"); 
	
	result.value  = var9;
	calc();

}		


function calc() {
	var res1 = 0;
	var res2 = 0;
	
	res1 = var2 + var3 + var4 + var5 + var6 + var7 + var8 + var9;
	res2 = var1 *(var2 + var3 + var4 + var5 + var6 + var7 + var8 + var9);
	
	var result1 = document.getElementById("varRes1"); 
	var result2 = document.getElementById("varRes2"); 
	
	result1.value  = res1;
	result2.value  = res2;	
	
	var resTxt = document.getElementById("txt"); 
	resTxt.value  = 'Брошюры. Количество: ' + var1 +' Формат: ' + type + ', Цветность обложки: ' + color + ', Бумага обложки: ' + paper +
	', Цветность вн. блока: '+ color2 + ', Бумага вн. блока: ' + paper2 + ', Качество: ' + qual + ', Кол-во полос: ' + var9 + ', Крепление: ' + k;	
		
}
	
	
</script>




<section id="serv">
	<div class="container">
		<div class="row  animated fadeInRight delay-0-1">
			<h1 class="title">Брошюры</h1>
			<h2 class="subtitle"></h2>

			<div class="col-md-12 col-sm-12">
				<p style="text-align: justify;"></p>				
			</div>
		</div>
		
		<div class="col-md-12 col-xl-12  animated fadeInRight delay-0-3">

			<legend>Форма заказа </legend>
			
			<form class="well form-horizontal" action="http://www.prostoysoft.ru/sendform.aspx?formtype=PsPrintFormBrochure" method="post"  id="contact_form">
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
								<td><input type="text" class="form-control res-control" id="var3" disabled ><p class="help-block">Цв. вн. блока</p></td>
								<td><input type="text" class="form-control res-control" id="var4" disabled ><p class="help-block">Бум. вн. блока</p></td>
								<td><input type="text" class="form-control res-control" id="var5" disabled ><p class="help-block">Кол-во полос</p></td>
								<td style="vertical-align: baseline;padding-top: 5px;font-weight: bold;"><b>=</b> </td>
								<td><input type="text" class="form-control res-control" id="varRes1" disabled ><p class="help-block">Цена тиража</p></td>
							</tr>
							<tr>								
								<td></td>
								<td></td>
								<td><input type="text" class="form-control res-control" id="var6" disabled ><p class="help-block">Цв.обложки</p></td>
								<td><input type="text" class="form-control res-control" id="var7" disabled ><p class="help-block">Бум. обложки</p></td>
								<td><input type="text" class="form-control res-control" id="var8" disabled ><p class="help-block">Крепление</p></td>
								<td></td>
								<td><input type="text" class="form-control res-control" id="varRes2" disabled ><p class="help-block">Цена шт.</p></td>
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
							<td colspan="8"><label>Цветность обложки</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar2_01" onClick="fnVar2(1)"  class="btn btn-default btn-sm">1+0</button></td>	
							<td><button type="button" id="btnVar2_02" onClick="fnVar2(2)"  class="btn btn-default btn-sm">1+1</button></td>
							<td><button type="button" id="btnVar2_03" onClick="fnVar2(3)"  class="btn btn-default btn-sm">4+0</button></td>
							<td><button type="button" id="btnVar2_04" onClick="fnVar2(4)"  class="btn btn-default btn-sm">4+4</button></td>								
						</tr>							
					</table>	
					
					<table class="tbl">
						<tr>
							<td colspan="5"><label>Бумага обложки</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar4_01" onClick="fnVar5(1)"  class="btn btn-default btn-sm">Простая</button></td>	
							<td><button type="button" id="btnVar4_02" onClick="fnVar5(2)"  class="btn btn-default btn-sm">90-130 г/м2</button></td>
							<td><button type="button" id="btnVar4_03" onClick="fnVar5(3)"  class="btn btn-default btn-sm">150-170 г/м2</button></td>
							<td><button type="button" id="btnVar4_04" onClick="fnVar5(4)"  class="btn btn-default btn-sm">180-200 г/м2</button></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar4_06" onClick="fnVar5(5)"  class="btn btn-default btn-sm">210-230 г/м2</button></td>	
							<td><button type="button" id="btnVar4_07" onClick="fnVar5(6)"  class="btn btn-default btn-sm">250-280 г/м2</button></td>
							<td><button type="button" id="btnVar4_08" onClick="fnVar5(7)"  class="btn btn-default btn-sm">290-300 г/м2</button></td>
							<td><button type="button" id="btnVar4_09" onClick="fnVar5(8)"  class="btn btn-default btn-sm">310-330 г/м2</button></td>
						</tr>						
					</table>

					<table class="tbl">
						<tr>
							<td colspan="8"><label>Качество</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar7_01" onClick="fnVar7(1)"  class="btn btn-default btn-sm">Office Pro</button></td>	
							<td><button type="button" id="btnVar7_02" onClick="fnVar7(2)"  class="btn btn-default btn-sm">Pro Plus</button></td>						
						</tr>					
					</table>	
					
					<table class="tbl">
						<tr>
							<td colspan="8"><label>Крепление</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar7_01" onClick="fnVar8(1)"  class="btn btn-default btn-sm">на скобу</button></td>	
							<td><button type="button" id="btnVar7_01" onClick="fnVar8(2)"  class="btn btn-default btn-sm">на пружину</button></td>	
							<td><button type="button" id="btnVar7_01" onClick="fnVar8(3)"  class="btn btn-default btn-sm">на клей</button></td>	
						</tr>					
					</table>	
								
					
				</div>
				
				
				<div class="col-md-6 selectContainer">
					<table class="tbl">
						<tr>
							<td colspan="5"><label>Формат</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(1)"  class="btn btn-default btn-sm">50х50</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(2)"  class="btn btn-default btn-sm">100х100</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(3)"  class="btn btn-default btn-sm">А6</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(4)"  class="btn btn-default btn-sm">Евро</button></td>	
						</tr>
						<tr>
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(5)"  class="btn btn-default btn-sm">150х150</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(6)"  class="btn btn-default btn-sm">А5</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(7)"  class="btn btn-default btn-sm">100х300</button></td>	
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(8)"  class="btn btn-default btn-sm">210х210</button></td>	
						</tr>
						<tr>
							<td><button type="button" id="btnVar4_01" onClick="fnVar3(9)"  class="btn btn-default btn-sm">А4</button></td>	
							<td></td>
							<td></td>
							<td></td>
						</tr>						
					</table>

					
					<table class="tbl">
						<tr>
							<td colspan="8"><label>Цветность вн. блока</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar2_01" onClick="fnVar4(1)"  class="btn btn-default btn-sm">1+0</button></td>	
							<td><button type="button" id="btnVar2_02" onClick="fnVar4(2)"  class="btn btn-default btn-sm">1+1</button></td>
							<td><button type="button" id="btnVar2_03" onClick="fnVar4(3)"  class="btn btn-default btn-sm">4+0</button></td>
							<td><button type="button" id="btnVar2_04" onClick="fnVar4(4)"  class="btn btn-default btn-sm">4+4</button></td>								
						</tr>							
					</table>	
					
					<table class="tbl">
						<tr>
							<td colspan="5"><label>Бумага вн. блока</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar4_01" onClick="fnVar6(1)"  class="btn btn-default btn-sm">Простая</button></td>	
							<td><button type="button" id="btnVar4_02" onClick="fnVar6(2)"  class="btn btn-default btn-sm">90-130 г/м2</button></td>
							<td><button type="button" id="btnVar4_03" onClick="fnVar6(3)"  class="btn btn-default btn-sm">150-170 г/м2</button></td>
							<td><button type="button" id="btnVar4_04" onClick="fnVar6(4)"  class="btn btn-default btn-sm">180-200 г/м2</button></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar4_06" onClick="fnVar6(5)"  class="btn btn-default btn-sm">210-230 г/м2</button></td>	
							<td><button type="button" id="btnVar4_07" onClick="fnVar6(6)"  class="btn btn-default btn-sm">250-280 г/м2</button></td>
							<td><button type="button" id="btnVar4_08" onClick="fnVar6(7)"  class="btn btn-default btn-sm">290-300 г/м2</button></td>
							<td><button type="button" id="btnVar4_09" onClick="fnVar6(8)"  class="btn btn-default btn-sm">310-330 г/м2</button></td>
						</tr>						
					</table>
					
					
					<table class="tbl">
						<tr>
							<td colspan="8"><label>Количество полос</label></td>
						</tr>
						<tr>
							<td><button type="button" id="btnVar1_01" onClick="fnVar9(2)" class="btn btn-default btn-sm">2</button></td>	
							<td><button type="button" id="btnVar1_02" onClick="fnVar9(4)"  class="btn btn-default btn-sm">4</button></td>
							<td><button type="button" id="btnVar1_03" onClick="fnVar9(6)"  class="btn btn-default btn-sm">6</button></td>
							<td><button type="button" id="btnVar1_04" onClick="fnVar9(8)"  class="btn btn-default btn-sm">8</button></td>							
						</tr>
						<tr>
							<td><button type="button" id="btnVar1_09" onClick="fnVar9(10)"  class="btn btn-default btn-sm">10</button></td>	
							<td><button type="button" id="btnVar1_10" onClick="fnVar9(12)"  class="btn btn-default btn-sm">12</button></td>
							<td><button type="button" id="btnVar1_11" onClick="fnVar9(14)"  class="btn btn-default btn-sm">14</button></td>
							<td><button type="button" id="btnVar1_12" onClick="fnVar9(16)"  class="btn btn-default btn-sm">16</button></td>							
						</tr>
						<tr>
							<td><button type="button" id="btnVar1_17" onClick="fnVar9(18)"  class="btn btn-default btn-sm">18</button></td>	
							<td><button type="button" id="btnVar1_18" onClick="fnVar9(20)"  class="btn btn-default btn-sm">20</button></td>
							<td><button type="button" id="btnVar1_19" onClick="fnVar9(22)"  class="btn btn-default btn-sm">22</button></td>
							<td><button type="button" id="btnVar1_20" onClick="fnVar9(24)"  class="btn btn-default btn-sm">24</button></td>							
						</tr>	
						<tr>
							<td><button type="button" id="btnVar1_17" onClick="fnVar9(26)"  class="btn btn-default btn-sm">26</button></td>	
							<td><button type="button" id="btnVar1_18" onClick="fnVar9(28)"  class="btn btn-default btn-sm">28</button></td>
							<td><button type="button" id="btnVar1_19" onClick="fnVar9(30)"  class="btn btn-default btn-sm">30</button></td>
							<td><button type="button" id="btnVar1_20" onClick="fnVar9(32)"  class="btn btn-default btn-sm">32</button></td>							
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