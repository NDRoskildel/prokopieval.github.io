<?php include 'header1.php'; ?>

<?php include 'header2.php'; ?>

<script type="text/javascript">
window.onload = function(){	calc();	}

function calc() {
	var design = document.getElementById("design");
	var size = document.getElementById("size");
	var paper = document.getElementById("paper");
	//var side = document.getElementById("side");
	var edition = document.getElementById("edition"); 

	var result = document.getElementById("result"); 

	var designInt = 0;
	var sizeInt = 0;
	var paperInt = 0;
	//var sideInt = 0;

	if (design.selectedIndex == 0) designInt = 0;
	if (design.selectedIndex == 1) designInt = 200;
	if (design.selectedIndex == 2) designInt = 100;
	
	if (size.selectedIndex == 0) sizeInt = 1;
	if (size.selectedIndex == 1) sizeInt = 2;
	if (size.selectedIndex == 2) sizeInt = 3;
	
	if (paper.selectedIndex == 0) paperInt = 3;
	if (paper.selectedIndex == 1) paperInt = 4;
	if (paper.selectedIndex == 2) paperInt = 5;
	if (paper.selectedIndex == 3) paperInt = 6;
	if (paper.selectedIndex == 4) paperInt = 7;
	
	/*
	if (side.selectedIndex == 0) sideInt = 5;
	if (side.selectedIndex == 1) sideInt = 6;
	*/
	
	var price = 0;
	price = designInt + (sizeInt * paperInt);
	price = price * parseInt(edition.options[edition.selectedIndex].value);
	
	result.innerHTML = price;
}

</script>
<section id="serv">
	<div class="container">
		<div class="row  animated fadeInRight delay-0-1">
			<h1 class="title">Наклейки</h1>
			<h2 class="subtitle"></h2>

			<div class="col-md-12 col-sm-12">
				<p style="text-align: justify;"></p>				
			</div>
		</div>
		
		<div class="col-md-12 col-xl-12  animated fadeInRight delay-0-3">

			<legend>Форма заказа </legend>
			
			<form class="well form-horizontal" action="http://www.prostoysoft.ru/sendform.aspx?formtype=PsPrintFormSticker" method="post"  id="contact_form">
			<fieldset>

			<div class="form-group">
				<div class="col-md-4"></div>
				
				<div class="col-md-4 inputGroupContainer">
					<div class="line"></div>
				</div>
			</div>

			
			<div class="form-group"> 
				<label class="col-md-4 control-label">Дизайн</label>
				<div class="col-md-4 selectContainer">
					<div class="input-group">
					<span class="input-group-addon"></span>
						<select  onchange="calc()" id="design" name="design" class="form-control">
							<option>Имеется свой оригинал-макет</option>
							<option>Требуется дизайн макета</option>
							<option>Требуется корректировка имеющегося макета</option>
						</select>				
					</div>
				</div>
			</div>

			<div class="form-group"> 
				<label class="col-md-4 control-label">Размер</label>
				<div class="col-md-4 selectContainer">
					<div class="input-group">
					<span class="input-group-addon"></span>
						<select onchange="calc()" id="size" name="size" class="form-control">
							<option>297x210 A4</option>
							<option>148x210 A5</option>
							<option>105x148 A6</option>
						</select>				
					</div>
				</div>
			</div>
			

			<div class="form-group">
			  <label class="col-md-4 control-label">Свой размер</label>  
				<div class="col-md-4 inputGroupContainer">
				<div class="input-group">
					<span class="input-group-addon"></span>
					<input name="other-size" id="other-size" type="text" class="form-control" placeholder="0" >								 
				</div>
			  </div>
			</div>

					
			<div class="form-group"> 
				<label class="col-md-4 control-label">Бумага</label>
				<div class="col-md-4 selectContainer">
					<div class="input-group">
					<span class="input-group-addon"></span>
						<select onchange="calc()" id="paper" name="paper" class="form-control">
							<option>Матовая самоклеющаяся бумага</option>
							<option>Глянцевая самоклеющаяся бумага</option>
						</select>				
					</div>
				</div>
			</div>


			<div class="form-group"> 
				<label class="col-md-4 control-label">Тираж</label>
				<div class="col-md-4 selectContainer">
					<div class="input-group">
						<span class="input-group-addon"></span>
						<select onchange="calc()" id="edition" name="edition" class="form-control">
							<option>50</option>
							<option>100</option>
							<option>200</option>
							<option>300</option>
							<option>400</option>
							<option>500</option>
							<option>600</option>
							<option>700</option>
							<option>800</option>
							<option>900</option>
							<option>1000</option>
							<option>Более 1000</option>
						</select>				
					</div>
				</div>
			</div>

			<div class="form-group">
			  <label class="col-md-4 control-label">Другой тираж</label>  
				<div class="col-md-4 inputGroupContainer">
				<div class="input-group">
					<span class="input-group-addon"></span>
					<input  name="other-edition" id="other-edition" type="text" class="form-control" placeholder="0" >								 
				</div>
			  </div>
			</div>
			
			<div class="form-group"> 
			  <label class="col-md-4 control-label">Примерная стоимость:</label>
				<div class="col-md-4 selectContainer">
				<div class="input-group">
					<div><span id="result">0</span> руб.</div>					
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