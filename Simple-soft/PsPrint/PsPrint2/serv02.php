<?php include 'header1.php'; ?>

<?php include 'header2.php'; ?>


<script type="text/javascript">
//window.onload = function(){	calc();	}
	  
var var1 = 0; // тираж
var var2 = 0; // тип каллендаря
var var3 = 0; // качество

var typeCal = 'Моно';
var qual = 'Office Pro';

 
//тираж
function fnVar1(v1) {
	var cnt = 1;	
	var1 = v1;
	
	var result1 = document.getElementById("var1"); 
	
	result1.value  = var1;
	calc();
}

//тип каллендаря
function fnVar2(v2) {

	if (v2 === 1 ){typeCal = 'Моно'; var2 = v2; }
	if (v2 === 2 ){typeCal = 'Трио-станд.'; var2 = v2; }
	if (v2 === 3 ){typeCal = 'Настен. А4 перекид.'; var2 = v2; }
	if (v2 === 4 ){typeCal = 'Настен. А3 перекид.'; var2 = v2; }
	if (v2 === 5 ){typeCal = 'Домик прост. верт. 180х100'; var2 = v2; }
	if (v2 === 6 ){typeCal = 'Домик гориз. 210х100'; var2 = v2; }
	
	var result2 = document.getElementById("var2"); 
	result2.value = typeCal;
	calc();
}


//качество
function fnVar3(v) {
	if (v === 1 ){var3 = v; qual = 'Office Pro'; }
	if (v === 2 ){var3 = v; qual = 'Pro Plus'; }
	
	calc();
}		

function calc() {
	var res1 = 0;
	var res2 = 0;
	
	res1 = var2 + var3;
	res2 = var1 *(var2 + var3);
	
	var result1 = document.getElementById("varRes1"); 
	var result2 = document.getElementById("varRes2"); 
	
	result1.value  = res1;
	result2.value  = res2;	
	
	var resTxt = document.getElementById("txt"); 
	resTxt.value  = 'Календари. Количество: ' + var1 +', Тип календаря: ' + typeCal + ', Качество: ' + qual;	
	
}
	
</script>

<section id="serv">
	<div class="container">
		<div class="row  animated fadeInRight delay-0-1">
			<h1 class="title">Календари</h1>
			<h2 class="subtitle"></h2>

			<div class="col-md-12 col-sm-12">
				<p style="text-align: justify;"></p>				
			</div>
		</div>
		
		<div class="col-md-12 col-xl-12  animated fadeInRight delay-0-3">

			<legend>Форма заказа </legend>
			
			<form class="well form-horizontal" action="http://www.prostoysoft.ru/sendform.aspx?formtype=PsPrintFormCalendar" method="post"  id="contact_form">
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
								<td><input type="text" class="form-control res-control" id="var2" disabled ><p class="help-block">Тип календаря</p></td>
								<td><input type="text" class="form-control res-control" id="varRes1" disabled ><p class="help-block">Цена шт., руб.</p></td>
								<td style="vertical-align: baseline;padding-top: 5px;font-weight: bold;"><b>=</b> </td>
								<td><input type="text" class="form-control res-control" id="varRes2" disabled ><p class="help-block">Цена тиража</p></td>
							</tr>															
						</table>												
					</div>
				</div>

				<div class="col-md-12 selectContainer">
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
								<td colspan="8"><label>Тип календаря</label></td>
							</tr>
							<tr>
								<td><button type="button" id="btnVar2_01" onClick="fnVar2(1)"  class="btn btn-default btn-sm">Моно</button></td>	
								<td><button type="button" id="btnVar2_02" onClick="fnVar2(2)"  class="btn btn-default btn-sm">Трио-станд.</button></td>
								<td><button type="button" id="btnVar2_03" onClick="fnVar2(3)"  class="btn btn-default btn-sm">Настен. А4 перекид.</button></td>
								<td><button type="button" id="btnVar2_04" onClick="fnVar2(4)"  class="btn btn-default btn-sm">Настен. А3 перекид.</button></td>	
								<td><button type="button" id="btnVar2_05" onClick="fnVar2(5)"  class="btn btn-default btn-sm">Домик прост. верт. 180х100</button></td>	
								<td><button type="button" id="btnVar2_06" onClick="fnVar2(6)"  class="btn btn-default btn-sm">Домик гориз. 210х100</button></td>									
							</tr>							
						</table>						
					
					
						<table class="tbl">
							<tr>
								<td colspan="8"><label>Качество</label></td>
							</tr>
							<tr>
								<td><button type="button" id="btnVar7_01" onClick="fnVar3(1)"  class="btn btn-default btn-sm">Office Pro</button></td>	
								<td><button type="button" id="btnVar7_02" onClick="fnVar3(2)"  class="btn btn-default btn-sm">Pro Plus</button></td>						
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