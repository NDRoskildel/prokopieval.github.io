<?php
include "header.php";
?>

<div class="general"> <!-- flyers -->
	<form id = "PsPrintFormFlyers" action="http://www.prostoysoft.ru/sendform.aspx?formtype=PsPrintFormFlyers" method="post">
		<div class="general-contact">
			<h1>Печать листовок</h1>
			<div class="line-gray"></div>
			<div class="print-img">
				<img src="images/img2_3.png">
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

		<div class="general-form form-flyer">
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
							<option>297x210 A4</option>
							<option>148x210 A5</option>
							<option>105x148 A6</option>
						</select>
					</div>
					<div class="general-field">
						<label for="other-size">Свой размер</label>
						<input name="other-size" id="other-size" type="text">
					</div>
					<div class="general-field">
						<label for="paper">Бумага</label>
						<select id="paper" name="paper" class="form-control">
							<option>Картон 300 г/м</option>
							<option>Бумага 200 гр/м</option>
							<option>Бумага 160 гр/м</option>
							<option>Бумага 150 гр/м</option>
							<option>Бумага 120 гр/м</option>
							<option>Бумага 100 гр/м</option>
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
					</div >
					<div class="general-field">
						<label for="other-edition">Другой тираж</label>
						<input name="other-edition" id="other-edition" type="text">
					</div>
					<input class="general-submit" type="submit">
				</div>
			</div>
		</div>
	</form>
</div><!--end flyers -->

<?php
include "footer.php";
?>