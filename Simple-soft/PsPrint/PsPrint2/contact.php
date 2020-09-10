<?php include 'header1.php'; ?>

<?php include 'header2.php'; ?>

<section id="serv">


<div class="container">

	<div class="row">
	
		<h3>Наш адрес </h3>
		<div class="col-md-6 col-xl-12">	
			<div class="contact-info">
				<p><i class="fa fa-map-marker"></i> 193318, Россия, г. Санкт-Петербург, ул. Ворошилова, д. 2, офис № 104</p>
				<p><i class="fa fa-phone"></i> +7 (812) 989-22-11</p>
				<p><i class="fa fa-phone"></i> +7 (952) 214-95-91</p>
				<p><i class="fa fa-envelope"></i> psprint@prostoysoft.ru</p>
			</div>
		</div>
		
		<div class="col-md-6 col-xl-12">
			<div class="mapSize">
				<script type="text/javascript" charset="utf-8" async src="https://api-maps.yandex.ru/services/constructor/1.0/js/?um=constructor%3Aef2060c843807bdede62aca7de551d82dde61d272f86990898c8815878182bab&amp;width=100%&amp;height=400&amp;lang=ru_RU&amp;scroll=true"></script>		
		`	</div>
		</div>
	
	</div>

	<form class="well form-horizontal" action="sendform.aspx?formtype=GiveMeLinkClientsCount" method="post"  id="contact_form">
	<fieldset>

	<!-- Form Name -->
	<legend>Свяжитесь с нами!</legend>

	<!-- Text input-->

	<div class="form-group">
	  <label class="col-md-4 control-label">Имя*</label>  
	  <div class="col-md-4 inputGroupContainer">
	  <div class="input-group">
	  <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
	  <input id="InputFio" name="InputFio" placeholder="Имя и отчество, Имя или ФИО" class="form-control"  type="text" required>
		</div>
	  </div>
	</div>

	<!-- Text input-->
		   <div class="form-group">
	  <label class="col-md-4 control-label">E-Mail*</label>  
		<div class="col-md-4 inputGroupContainer">
		<div class="input-group">
			<span class="input-group-addon"><i class="glyphicon glyphicon-envelope"></i></span>
	  <input id="InputEmail" name="InputEmail"  placeholder="@" class="form-control"  type="text" required>
		</div>
	  </div>
	</div>


	<!-- Text input-->		   
	<div class="form-group">
	  <label class="col-md-4 control-label">Телефон</label>  
		<div class="col-md-4 inputGroupContainer">
		<div class="input-group">
			<span class="input-group-addon"><i class="glyphicon glyphicon-earphone"></i></span>
	  <input id="InputPhone" name="InputPhone" placeholder="+7(XXX) XXX-XX-XX" class="form-control" type="text">
		</div>
	  </div>
	</div>

	  
	<div class="form-group">
	  <label class="col-md-4 control-label">Сообщение</label>
		<div class="col-md-4 inputGroupContainer">
		<div class="input-group">
			<span class="input-group-addon"><i class="glyphicon glyphicon-pencil"></i></span>
				<textarea class="form-control" name="comment" placeholder="Сообщение"></textarea>
	  </div>
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
	
	<!-- Success message -->
	<!--
	<div class="alert alert-success" role="alert" id="success_message">Success <i class="glyphicon glyphicon-thumbs-up"></i> Thanks for contacting us, we will get back to you shortly.</div>
	-->
	
	
	<!-- Button -->
	<div class="form-group">
	  <label class="col-md-4 control-label"></label>
	  <div class="col-md-4">
		<button type="submit" class="btn btn-warning" >Отправить <span class="glyphicon glyphicon-send"></span></button>
	  </div>
	</div>

	<div class="col-md-12 form-valid">*поля обязательны для заполнения</div>
	</fieldset>
	</form>
</div>

	
</section>


<?php include 'footer.php'; ?>