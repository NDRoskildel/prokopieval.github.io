	
<!-- Conatct Section -->
<section id="contact">
	<div class="container text-center">
		<div class="row  animated fadeInRight delay-0-5">
			<div class="col-md-12 wow fadeInRight">
				<div class="social-links">
					<a class="social" href="#" target="_blank"><i class="fa fa-facebook fa-2x"></i></a>
					<a class="social" href="#" target="_blank"><i class="fa fa-twitter fa-2x"></i></a>
					<a class="social" href="https://vk.com/prostoysoft" target="_blank"><i class="fa fa-vk fa-2x"></i></a>
				</div>
				<div class="contact-info">
					<p><i class="fa fa-map-marker"></i> 193318, Россия, г. Санкт-Петербург, ул. Ворошилова, д. 2, офис № 104</p>
					<p><i class="fa fa-phone"></i> +7 (812) 989-22-11</p>
					<p><i class="fa fa-phone"></i> +7 (952) 214-95-91</p>
					<p><i class="fa fa-envelope"></i> psprint@prostoysoft.ru</p>
				</div>

				<p>
					Наша организация работает по рабочим дням с 10:00 до 18:00 по московскому времени<br>
				</p>

			</div>

		</div>
	</div>
</section>


	<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
	  <div class="modal-dialog">
		<div class="modal-content">
		  <div class="modal-header">
			<button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
			<h4 class="modal-title">Введите данные для связи с Вами</h4>
			<span class="modal-title"></span>
		  </div>
		  <form class="form-horizontal" role="form" id="CallToActionForm" action="sendform.aspx?formtype=GiveMeLinkClientsCount" enctype="multipart/form-data" method="post">		  		  
			  <div class="modal-body">					  				
				  <div class="form-group">
					<label for="InputFio" class="col-sm-4 control-label">Ваше имя</label>
					<div class="col-sm-6">
					  <input type="text" class="form-control" placeholder="Имя и отчество, Имя или ФИО" id="InputFio" name="InputFio" />
					</div>
				  </div>
				  <div class="form-group">
					<label for="InputPhone" class="col-sm-4 control-label">Ваш телефон</label>
					<div class="col-sm-6">
					  <input type="text" class="form-control" placeholder="+7(XXX) XXX-XX-XX" id="InputPhone" name="InputPhone" />
					</div>
				  </div>
				  <div class="form-group">
					<label for="InputEmail" class="col-sm-4 control-label">Ваш емейл</label>
					<div class="col-sm-6">
					  <input type="text" class="form-control" placeholder="@" id="InputEmail" name="InputEmail" />
					</div>
				  </div>

			  </div>
			  <div class="modal-footer">
				<input type="submit" value="Отправить заявку!" id="submit1" name="submit1" class="btn btn-success" />
			  </div>
			  
		 </form>
		</div><!-- /.modal-content -->
	  </div><!-- /.modal-dialog -->
	</div><!-- /.modal -->


</body>
	<script src="js/jquery.min.js"></script>	
	<script src="js/bootstrap.min.js"></script>
	<script src="js/lightbox.min.js"></script>
	<script src="js/main.js"></script>
	
</html>
