<?php
include "header.php";
?>

<div class="general"> <!-- cutaway -->
	<form id = "PsPrintFormCutaway" action="http://www.prostoysoft.ru/sendform.aspx?formtype=PsPrintFormCards" method="post">
		<div class="general-contact">
			<h1>Печать визиток</h1>
			<div class="line-gray"></div>
			<div class="print-img">
				<img src="images/img2_1.png">
			</div>
			<div class="general-contact-container">
				<h2>Контактные данные</h2>
				<div class="form-block">
					
					<div class="field">
						<label for="fio"><span class="star">*</span>Ф.И.О.</label>
						<input id="fio" name="fio" type="text"><br>
					</div>
					<div class="field">
						<label for="phone"><span class="star">*</span>Тел.</label>
						<input id="phone" name="phone" type="text"><br>
					</div>
					<div class="field">
						<label for="addres">Адрес</label>
						<input id="addres" name="addres" type="text"><br>
					</div>
					<div class="field">
						<label for="e-mail"><span class="star">*</span>E-mail</label>
						<input id="e-mail" name="e-mail" type="text"><br>
					</div>
					
				</div>
				<div class="note">
					<span class="star">*</span>поля обязательны для заполнения
				</div>
			</div>
		</div>

		<div class="general-form form-cutaway">
			<h2>Форма заказа</h2>
			<div class="line-white">
				<div class="form-general-block">
					<div class="general-field">
						<label for="design">Дизайн</label>
						<select id="design" name="design" class="form-control">
							<option>Имеется свой оригинал-макет</option>
							<option>Требуется дизайн макета</option>
							<option>Требуется корректировка имеющегося макета</option>
						</select>
					</div>
					<div class="general-field">
						<label for="size">Размер</label>
						<select id="size" name="size" class="form-control">
							<option>Стандарт 90x50 мм</option>
							<option>Евро 85x55 мм</option>
						</select>
					</div>
					<div class="general-field">
						<label for="paper">Бумага</label>
						<select id="paper" name="paper" class="form-control">
							<option>Картон 300 г/м</option>
							<option>Другая ???</option>
						</select>
					</div>
					<div class="general-field">
						<label for="side">Стороны печати</label>
						<select class="mini-select" id="side" name="side" class="form-control">
							<option>Только лицо</option>
							<option>Лицо и оборот</option>
						</select>
					</div>
					<div class="general-field">
						<label for="edition">Тираж</label>
						<select id="edition" name="edition" class="form-control">
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
					</div >
					<input class="general-submit" type="submit">
				</div>
			</div>
		</div>
	</form>
</div><!--end cutaway -->

<?php
include "footer.php";
?>