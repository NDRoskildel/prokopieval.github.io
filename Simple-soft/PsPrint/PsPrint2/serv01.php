<?php include 'header1.php'; ?>

<?php include 'header2.php'; ?>


<script type="text/javascript">
//window.onload = function(){	calc();	}
	  
var var1 = 0; // количество
var var2 = 0; // комплекты
var var3 = 0; // цветность

var var4 = 0; // ламинация 
var var5 = 0; // бумага

var var6 = 0; // скругление углов
var var7 = 0; // срочность
var var8 = 0; // качество

var color = '1+0';
var paper = '300 г/м2';
var qual = 'Office Pro';


//комплекты
function fnVar1(v1) {
	var cnt = 96;
	
	var1 = v1;
	var2 = v1*cnt;
	
	var result1 = document.getElementById("var1"); 
	var result2 = document.getElementById("var2"); 
	
	result1.value  = var1;
	result2.value  = var2;
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

/*
//ламинация
function fnVar3(v) {
	if (v === 1 ){var4 = v; }
	if (v === 2 ){var4 = v; }
	if (v === 3 ){var4 = v; }
	calc();
}
*/

//бумага
function fnVar4(v) {
		
	if (v === 1 ){paper = '300 г/м2'; var5 = v; }
	if (v === 2 ){paper = '350 г/м2'; var5 = v; }
	if (v === 3 ){paper = 'touch cover'; var5 = v; }
	if (v === 4 ){paper = 'jade silk'; var5 = v; }
	if (v === 5 ){paper = 'Majestic'; var5 = v; }
	
	if (v === 6 ){paper = 'Белый лен'; var5 = v; }
	if (v === 7 ){paper = 'Кат. 1'; var5 = v; }
	if (v === 8 ){paper = 'Кат. 2'; var5 = v; }
	if (v === 9 ){paper = 'Кат. 3'; var5 = v; }
	if (v === 10 ){paper = 'Кат. 4'; var5 = v; }
	
	var result5 = document.getElementById("var4"); 
	result5.value = paper;
	calc();
}

/*
// скругление углов
function fnVar5(v) {
	if (v === 1 ){var6 = v; }
	if (v === 2 ){var6 = v; }
	if (v === 3 ){var6 = v; }
	if (v === 4 ){var6 = v; }
	if (v === 5 ){var6 = v; }
calc();	
}
*/

/*
//срочность
function fnVar6(v) {
	if (v === 1 ){var7 = v; }
	if (v === 2 ){var7 = v; }
	if (v === 3 ){var7 = v; }
	calc();
}
*/

//качество
function fnVar7(v) {
	if (v === 1 ){var8 = v; qual = 'Office Pro'; }
	if (v === 2 ){var8 = v; qual = 'Pro Plus'; }
	
	calc();
}		

function calc() {
	var res1 = 0;
	var res2 = 0;
	
	res1 = var3 + var5 + var8;
	res2 = var2 *(var3 + var5 + var8);
	
	var result1 = document.getElementById("varRes1"); 
	var result2 = document.getElementById("varRes2"); 
	
	result1.value  = res1;
	result2.value  = res2;	
	
	var resTxt = document.getElementById("txt"); 
	resTxt.value  = 'Визитки. Количество: ' + var2 +', Цветность: ' + color + ', Бумага: ' + paper + ', Качество: ' + qual;	
}
	
</script>

<section id="serv">
	<div class="container">
		<div class="row  animated fadeInRight delay-0-1">
			<h1 class="title">Визитки</h1>
			<h2 class="subtitle">Печать визиток</h2>

			<div class="col-md-12 col-sm-12">
				<p style="text-align: justify;">Полиграфическая продукция нужна всем. Даже если вы не бизнесмен, а работаете специалистом в какой-то компании, вам наверняка пригодятся визитки. Ваш логотип, фирменный стиль, дизайн полиграфии - это лицо и имидж вашей компании. С этим вы проводите выставки, презентации, поздравляете клиентов и партнеров с праздниками. </p>				
			</div>
		</div>
		
		<div class="col-md-12 col-xl-12  animated fadeInRight delay-0-3">

			<legend>Форма заказа </legend>
			
			<form  onload="calc()" class="well form-horizontal" action="http://www.prostoysoft.ru/sendform.aspx?formtype=PsPrintFormCards" method="post"  id="contact_form">
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
								<td><input type="text" class="form-control res-control" id="var1" disabled ><p class="help-block">Комплектов</p></td>
								<td><input type="text" class="form-control res-control" id="var2" disabled ><p class="help-block">Тираж, шт.</p></td>
								<td><input type="text" class="form-control res-control" id="var3" disabled ><p class="help-block">Цветность</p></td>
								<td><input type="text" class="form-control res-control" id="var4" disabled ><p class="help-block">Бумага</p></td>
								<td><input type="text" class="form-control res-control" id="varRes1" disabled ><p class="help-block">Цена шт., руб.</p></td>
								<td style="vertical-align: baseline;padding-top: 5px;font-weight: bold;"><b>=</b> </td>
								<td><input type="text" class="form-control res-control" id="varRes2" disabled ><p class="help-block">Цена тиража</p></td>
							</tr>															
						</table>												
					</div>
				</div>
				
				
				<div class="col-md-12 selectContainer">
					<div class="col-md-6 selectContainer">
						<table class="tbl">
							<tr>
								<td colspan="8"><label>Комплект визиток</label></td>
							</tr>
							<tr>
								<td><button type="button" id="btnVar1_01" onClick="fnVar1(1)" class="btn btn-default btn-sm">1</button></td>	
								<td><button type="button" id="btnVar1_02" onClick="fnVar1(2)"  class="btn btn-default btn-sm">2</button></td>
								<td><button type="button" id="btnVar1_03" onClick="fnVar1(3)"  class="btn btn-default btn-sm">3</button></td>
								<td><button type="button" id="btnVar1_04" onClick="fnVar1(4)"  class="btn btn-default btn-sm">4</button></td>
								<td><button type="button" id="btnVar1_05" onClick="fnVar1(5)"  class="btn btn-default btn-sm">5</button></td>
								<td><button type="button" id="btnVar1_06" onClick="fnVar1(6)"  class="btn btn-default btn-sm">6</button></td>
								<td><button type="button" id="btnVar1_07" onClick="fnVar1(7)"  class="btn btn-default btn-sm">7</button></td>
								<td><button type="button" id="btnVar1_08" onClick="fnVar1(8)"  class="btn btn-default btn-sm">8</button></td>								
							</tr>
							<tr>
								<td><button type="button" id="btnVar1_09" onClick="fnVar1(9)"  class="btn btn-default btn-sm">9</button></td>	
								<td><button type="button" id="btnVar1_10" onClick="fnVar1(10)"  class="btn btn-default btn-sm">10</button></td>
								<td><button type="button" id="btnVar1_11" onClick="fnVar1(11)"  class="btn btn-default btn-sm">11</button></td>
								<td><button type="button" id="btnVar1_12" onClick="fnVar1(12)"  class="btn btn-default btn-sm">12</button></td>
								<td><button type="button" id="btnVar1_13" onClick="fnVar1(13)"  class="btn btn-default btn-sm">13</button></td>
								<td><button type="button" id="btnVar1_14" onClick="fnVar1(14)"  class="btn btn-default btn-sm">14</button></td>
								<td><button type="button" id="btnVar1_15" onClick="fnVar1(15)"  class="btn btn-default btn-sm">15</button></td>
								<td><button type="button" id="btnVar1_16" onClick="fnVar1(16)"  class="btn btn-default btn-sm">16</button></td>								
							</tr>
							<tr>
								<td><button type="button" id="btnVar1_17" onClick="fnVar1(17)"  class="btn btn-default btn-sm">17</button></td>	
								<td><button type="button" id="btnVar1_18" onClick="fnVar1(18)"  class="btn btn-default btn-sm">18</button></td>
								<td><button type="button" id="btnVar1_19" onClick="fnVar1(19)"  class="btn btn-default btn-sm">19</button></td>
								<td><button type="button" id="btnVar1_20" onClick="fnVar1(20)"  class="btn btn-default btn-sm">20</button></td>
								<td><button type="button" id="btnVar1_21" onClick="fnVar1(21)"  class="btn btn-default btn-sm">21</button></td>
								<td><button type="button" id="btnVar1_22" onClick="fnVar1(22)"  class="btn btn-default btn-sm">22</button></td>
								<td><button type="button" id="btnVar1_23" onClick="fnVar1(23)"  class="btn btn-default btn-sm">23</button></td>
								<td><button type="button" id="btnVar1_24" onClick="fnVar1(24)"  class="btn btn-default btn-sm">24</button></td>								
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
						<!----
						<table class="tbl">
							<tr>
								<td colspan="8"><label>Ламинация</label></td>
							</tr>
							<tr>
								<td><button type="button" id="btnVar3_01" onClick="fnVar3(1)"  class="btn btn-default btn-sm">нет</button></td>	
								<td><button type="button" id="btnVar3_02" onClick="fnVar3(2)"  class="btn btn-default btn-sm">32 мкн</button></td>
								<td><button type="button" id="btnVar3_03" onClick="fnVar3(3)"  class="btn btn-default btn-sm">150 мкн</button></td>							
							</tr>							
						</table>	
						-->
						
					</div>
					<div class="col-md-6 selectContainer">
						<table class="tbl">
							<tr>
								<td colspan="5"><label>Бумага</label></td>
							</tr>
							<tr>
								<td><button type="button" id="btnVar4_01" onClick="fnVar4(1)"  class="btn btn-default btn-sm">300 г/м2</button></td>	
								<td><button type="button" id="btnVar4_02" onClick="fnVar4(2)"  class="btn btn-default btn-sm">350 г/м2</button></td>
								<td><button type="button" id="btnVar4_03" onClick="fnVar4(3)"  class="btn btn-default btn-sm">touch cover</button></td>
								<td><button type="button" id="btnVar4_04" onClick="fnVar4(4)"  class="btn btn-default btn-sm">jade silk</button></td>
								<td><button type="button" id="btnVar4_05" onClick="fnVar4(5)"  class="btn btn-default btn-sm">Majestic</button></td>							
							</tr>
							<tr>
								<td><button type="button" id="btnVar4_06" onClick="fnVar4(6)"  class="btn btn-default btn-sm">Белый лен</button></td>	
								<td><button type="button" id="btnVar4_07" onClick="fnVar4(7)"  class="btn btn-default btn-sm">Кат. 1</button></td>
								<td><button type="button" id="btnVar4_08" onClick="fnVar4(8)"  class="btn btn-default btn-sm">Кат. 2</button></td>
								<td><button type="button" id="btnVar4_09" onClick="fnVar4(9)"  class="btn btn-default btn-sm">Кат. 3</button></td>
								<td><button type="button" id="btnVar4_10" onClick="fnVar4(10)"  class="btn btn-default btn-sm">Кат. 4</button></td>							
							</tr>						
						</table>

						<!---
						<table class="tbl">
							<tr>
								<td colspan="8"><label>Скругление углов</label></td>
							</tr>
							<tr>
								<td><button type="button" id="btnVar5_01" onClick="fnVar5(1)"  class="btn btn-default btn-sm">нет</button></td>	
								<td><button type="button" id="btnVar5_02" onClick="fnVar5(2)"  class="btn btn-default btn-sm">1 угол</button></td>
								<td><button type="button" id="btnVar5_03" onClick="fnVar5(3)"  class="btn btn-default btn-sm">2 угла</button></td>
								<td><button type="button" id="btnVar5_04" onClick="fnVar5(4)"  class="btn btn-default btn-sm">3 угла</button></td>
								<td><button type="button" id="btnVar5_05" onClick="fnVar5(5)"  class="btn btn-default btn-sm">4 угла</button></td>							
							</tr>					
						</table>						
						-->
						<!---
						<table class="tbl">
							<tr>
								<td colspan="8"><label>Срочность</label></td>
							</tr>
							<tr>
								<td><button type="button" id="btnVar6_01" onClick="fnVar6(1)"  class="btn btn-default btn-sm">не срочно</button></td>	
								<td><button type="button" id="btnVar6_02" onClick="fnVar6(2)"  class="btn btn-default btn-sm">побыстрее</button></td>
								<td><button type="button" id="btnVar6_03" onClick="fnVar6(3)"  class="btn btn-default btn-sm">срочно</button></td>							
							</tr>					
						</table>						
						-->
						<table class="tbl">
							<tr>
								<td colspan="8"><label>Качество</label></td>
							</tr>
							<tr>
								<td><button type="button" id="btnVar7_01" onClick="fnVar7(1)"  class="btn btn-default btn-sm">Office Pro</button></td>	
								<td><button type="button" id="btnVar7_02" onClick="fnVar7(2)"  class="btn btn-default btn-sm">Pro Plus</button></td>						
							</tr>					
						</table>																	
					</div>						
			
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