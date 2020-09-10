(function () {
    window.onload = function () {
        function removeChildren(element) {
            while (element.lastChild) {
                element.removeChild(element.lastChild);
            }
        }
        function summy() {
            var sum = 0;
            sum = listProgramms.getPrice(programm.value, license.value);
            if (service.value > 0) sum += listServices[service.value].price;
            if (configuration.value > 0) sum += 3000;
            return sum;
        }
        var listServices = {
            1: {
                "name": "Годовая подписка на обновление",
                "price": 2000
            },
            2: {
                "name": "Стандартная поддержка",
                "price": 6000
            },
            3: {
                "name": "Сеанс связи с ИТ-специалистом",
                "price": 2400
            },
            4: {
                "name": "Выезд специалиста в офис (2 часа)",
                "price": 3000
            },
            5: {
                "name": "Составление тех. задания (неделя)",
                "price": 20000
            },
            6: {
                "name": "Настройка конфигурации (неделя)",
                "price": 20000
            },
            7: {
                "name": "Другое",
                "price": 0
            }
        };
        var listLicenses = {
            1: {
                "name": "Базовая (1 р.м.)",
                "price": 3000
            },
            2: {
                "name": "Стандартная (3 р.м.)",
                "price": 9000
            },
            3: {
                "name": "Бизнес (5 р.м.)",
                "price": 15000
            },
            4: {
                "name": "Профессиональная (10 р.м.)",
                "price": 20000
            },
            5: {
                "name": "Корпоративная (20 р.м.)",
                "price": 25000
            },
            6: {
                "name": "Вип",
                "price": 29900
            }
        };
        var listProgramms = {
            1: {
                "name": "Учет клиентов",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            2: {
                "name": "Склад и торговля",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            3: {
                "name": "Учет компьютеров",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            4: {
                "name": "Учет пациентов",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            5: {
                "name": "Архив документов",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            6: {
                "name": "Учет поситителей",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            7: {
                "name": "Управление проектами",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            8: {
                "name": "Учет книг",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            9: {
                "name": "Мои диски",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            10: {
                "name": "Кулинарные рецепты",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            11: {
                "name": "Анализ результатов поиска",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            12: {
                "name": "Простой сайт",
                "licenseView": [4, 5, 6]
            },
            13: {
                "name": "PsPhone",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            14: {
                "name": "PsMobile",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            15: {
                "name": "Prostoysoft Tables 3.0",
                "licenseView": [1, 2, 3, 4, 5, 6]
            },
            getListLicenses : function (licenseNumber) {
                var obj = {};
                for (var j = 0; j < listProgramms[licenseNumber].licenseView.length; j++) {
                    obj[j] = {
                        "name": listLicenses[listProgramms[licenseNumber].licenseView[j]].name,
                        "price": listLicenses[listProgramms[licenseNumber].licenseView[j]].price
                    };
                }
                return obj;
            },
            getPrice: function (p_value, l_value) {
                if(p_value > 0 && l_value > 0)
                    return listLicenses[listProgramms[p_value].licenseView[l_value - 1]].price;
                return 0;
            }
        };
        var programm = document.getElementById("YandexKassaForm__programm");
        var license = document.getElementById("YandexKassaForm__license");
        var service = document.getElementById("YandexKassaForm__service");
        var price = document.getElementById("YandexKassaForm__price");
        var configuration = document.getElementById("YandexKassaForm__config");
        var another = document.getElementById("YandexKassaForm__another");
        var lbAnother = document.getElementById("YandexKassaForm__lbAnother");
        programm.onchange = function () {
            if (this.value > 0) {
                var list = listProgramms.getListLicenses(this.value);
                removeChildren(license);
                for (var i = 0; i < Object.keys(list).length; i++) {
                    var option = document.createElement("OPTION");
                    option.innerHTML = list[i].name;
                    option.value = i + 1;
                    license.appendChild(option);
                }
            }
            if (this.value == 0) {
                removeChildren(license);
                var option = document.createElement("OPTION");
                option.innerHTML = "Нет";
                option.value = 0;
                license.appendChild(option);
            }
            price.value = summy();
        };
        license.onchange = function () {
            price.value = summy();
        };
        service.onchange = function () {
            price.value = summy();
            if (service.value == 7) {
                another.hidden = false;
                lbAnother.hidden = false;
                another.focus();
            } else {
                another.hidden = true;
                lbAnother.hidden = true;
            }
        };
        configuration.onchange = function () {
            price.value = summy();
        };
    };
})();