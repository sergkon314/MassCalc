using System;
using System.Collections.Generic;
using System.Text;

namespace dms.pages.Utils
{

    public static class DmsStings
    {
        public static string[] MonthNames = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <param name="name">The name of page.</param>
        /// <returns>Page title</returns>
        public static string GetTitle(string name)
        {
            switch (name)
            {
                case PAGENAME_START:
                    return PAGETITLE_START;
                case PAGENAME_ADMIN:
                    return PAGETITLE_ADMIN;
                case PAGENAME_USERS:
                    return PAGETITLE_USERS;
                case PAGENAME_MASSBIDS:
                    return PAGETITLE_MASSBIDS;
                case PAGENAME_MASSCLAIM:
                    return PAGETITLE_MASSCLAIM;
                case PAGENAME_MASSCALC:
                    return PAGETITLE_MASSCALC;
            }
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        public const string MAINFRM_TYPE = "dms.MainFrm";
        /// <summary>
        /// "dms.pages.MainPage"
        /// </summary>
        public const string MAIN_TYPE = "dms.pages.MainPage";
        /// <summary>
        /// "Монолит.NET"
        /// </summary>
        public const string MSG_TITLE = "Монолит.NET";
        /// <summary>
        /// "Монолит.NET - Ошибка"
        /// </summary>
        public const string MSG_TITLE_E = "Монолит.NET - Ошибка";
        /// <summary>
        /// "Монолит.NET - Предупреждение"
        /// </summary>
        public const string MSG_TITLE_I = "Монолит.NET - Информация";
        /// <summary>
        /// "Монолит.NET - Подтверждение действия"
        /// </summary>
        public const string MSG_TITLE_WARNING_ACT = "Монолит.NET - Подтверждение действия";
        /// <summary>
        /// "Монолит.NET - Подтверждение действия"
        /// </summary>
        public const string MSG_TITLE_WARNING = "Монолит.NET - Предупреждение";
        /// <summary>
        /// "Монолит.NET"
        /// </summary>
        public const string MAINFRM_TITLE = "Монолит.NET";
        /// <summary>
        /// "dms.pages."
        /// </summary>
        public const string PAGE_NAMESPACE = "dms.pages.";
        /// <summary>
        /// "StartPage"
        /// </summary>
        public const string PAGENAME_START = "StartPage";
        /// <summary>
        /// "AdminPage"
        /// </summary>
        public const string PAGENAME_ADMIN = "AdminPage";
        /// <summary>
        /// "UserPage"
        /// </summary>
        public const string PAGENAME_USERS = "UserPage";
        /// <summary>
        /// "MassPage"
        /// </summary>
        public const string PAGENAME_MASSBIDS = "MassBids";
        /// <summary>
        /// "MassClaim"
        /// </summary>
        public const string PAGENAME_MASSCLAIM = "MassClaim";
        /// <summary>
        /// "MassClaim"
        /// </summary>
        public const string PAGENAME_MASSCALC = "MassCalc";
        /// <summary>
        /// "MailPage1"
        /// </summary>
        public const string PAGENAME_MAILPAGE_OOO = "EMailOOO";
        /// <summary>
        /// "MailPage2"
        /// </summary>
        public const string PAGENAME_MAILPAGE_OAO = "EMailOAO";
        /// <summary>
        /// "NtdPage"
        /// </summary>
        public const string PAGENAME_NTDPAGE = "NtdPage";
        /// <summary>
        /// "NtdLibPage"
        /// </summary>
        public const string PAGENAME_NTDLIBPAGE = "NtdLibPage";
        /// <summary>
        /// "NtdLibPrice"
        /// </summary>
        public const string PAGENAME_NTDLIBPRICE = "NtdLibPrice";
        /// <summary>
        /// "PacktsOOO"
        /// </summary>
        public const string PAGENAME_PACKTSOOO = "PacktsOOO";
        /// <summary>
        /// "PacktsOAO"
        /// </summary>
        public const string PAGENAME_PACKTSOAO = "PacktsOAO";
        /// <summary>
        /// "PacktsBV"
        /// </summary>
        public const string PAGENAME_PACKTSBV = "PacktsBV";
        /// <summary>
        /// "PacktsDeal"
        /// </summary>
        public const string PAGENAME_PACKTSDEAL = "PacktsDeal";
        public const string PAGENAME_PACKTSDCAM = "PacktsDCam";
        public const string PAGENAME_PPM = "PPMPage";
        public const string PAGENAME_PPMUSER = "PPMUserPage";
        public const string PAGENAME_PPMCALENDAR = "PPMCalendar";
        public const string PAGENAME_PPMARCHIVE = "PPMArchive";
        public const string PAGENAME_PPMOVERTIME = "PPMOverTime";

        public const string PAGENAME_ERPOAO = "ERPPageOAO";
        public const string PAGENAME_ERPOOO = "ERPPageOOO";
        public const string PAGENAME_ERPDOC = "ERPPageDOC";
        public const string PAGENAME_ERPHOZ = "ERPPageHOZ";
        public const string PAGENAME_ERPTND = "ERPPageTND";
        public const string PAGENAME_IZV = "IzvPage";

        public const string PAGENAME_SHIPS = "Ships";
        public const string PAGENAME_ARSHIPS = "ArShips";
        public const string PAGENAME_BUILD = "Build";
        public const string PAGENAME_ARBUILD = "ArBuild";
        public const string PAGENAME_GAAS = "Gaas";
        public const string PAGENAME_ARGAAS = "ArGaas";
        public const string PAGENAME_PRINT = "Print";
        public const string PAGENAME_TPROJECTS = "TProjects";
        public const string PAGENAME_NTD2PAGE = "Ntd2Page";
        public const string PAGENAME_SEARCHPROJECTS = "SearchProjects";
        public const string PAGENAME_SEARCHBUILD = "SearchBuild";
        public const string PAGENAME_SEARCHGAAS = "SearchGaas";
        public const string PAGENAME_SEARCHLEFT = "SearchLeft";
        public const string PAGENAME_LEFT = "LeftPage";
        public const string PAGENAME_JOB = "JobPage";
        /// <summary>
        /// ""
        /// </summary>
        public const string PAGETITLE_MAIN = "";
        /// <summary>
        /// "Стартовая страница"
        /// </summary>
        public const string PAGETITLE_START = "Стартовая страница";
        /// <summary>
        /// "Администрирование"
        /// </summary>
        public const string PAGETITLE_ADMIN = "Администрирование";
        /// <summary>
        /// "Настроки пользователей"
        /// </summary>
        public const string PAGETITLE_USERS = "Настроки пользователей";
        /// <summary>
        /// "Нагрузка масс"
        /// </summary>
        public const string PAGETITLE_MASSBIDS = "Заявки";
        /// <summary>
        /// "Нагрузка масс"
        /// </summary>
        public const string PAGETITLE_MASSCLAIM = "Утверждение заявок";
        /// <summary>
        /// "Нагрузка масс"
        /// </summary>
        public const string PAGETITLE_MASSCALC = "Расчеты";
        /// <summary>
        /// "Почта ООО ЦКБ Монолит"
        /// </summary>
        public const string PAGETITLE_MAILPAGE1 = "Почта ООО ЦКБ Монолит";
        /// <summary>
        /// "Почта ОАО ЦКБ Монолит"
        /// </summary>
        public const string PAGETITLE_MAILPAGE2 = "Почта ОАО ЦКБ Монолит";
        /// <summary>
        /// "База нормативных документов"
        /// </summary>
        public const string PAGETITLE_NTDPAGE = "База нормативных документов";
        /// <summary>
        /// "Библиотека НТД"
        /// </summary>
        public const string PAGETITLE_NTDLIBPAGE = "Библиотека НТД";
        /// <summary>
        /// "Библиотека прайсов"
        /// </summary>
        public const string PAGETITLE_NTDLIBPRICE = "Библиотека прайсов";
        //
        /// <summary>
        /// "Earth"
        /// </summary>
        public const string MAINFRM_ICON = "Earth";
        /// <summary>
        /// "Несовпадение типов сборок в процессе инициализации модуля."
        /// </summary>
        public const string MSG_INIT_FAIL_1 = "Несовпадение типов сборок в процессе инициализации модуля.";
        /// <summary>
        /// Шаблон "Не удалось найти модуль {0}."
        /// </summary>
        public const string MSG_INIT_FAIL_2 = "Не удалось найти модуль {0}.";
        /// <summary>
        /// Шаблон "Не удалось загрузить модуль {0}."
        /// </summary>
        public const string MSG_INIT_FAIL_3 = "Не удалось загрузить модуль {0}.";
        /// <summary>
        /// Шаблон "Не удалось инициализировать модуль {0}."
        /// </summary>
        public const string MSG_INIT_FAIL_4 = "Не удалось инициализировать модуль {0}.";
        /// <summary>
        /// Шаблон "Не удалось создать объект {0}."
        /// </summary>
        public const string MSG_INIT_FAIL_5 = "Не удалось создать объект {0}.";
        /// <summary>
        /// Шаблон "Не удалось инициализировать объект {0}."
        /// </summary>
        public const string MSG_INIT_FAIL_6 = "Не удалось инициализировать объект {0}.";
        /// <summary>
        /// Шаблон "Не удалось найти класс {0}."
        /// </summary>
        public const string MSG_INIT_FAIL_7 = "Не удалось найти класс {0}.";
        /// <summary>
        /// Единицы измерения дисковой квоты (мегабайт)
        /// </summary>
        public const string QUOTA_METER = "M";
        public const string USERNAME_NOT_FOUND = "Имя пользователя {0} не зарегистрировано в системе.";
        public const string FIFO_INIT_FAILED = "Ошибка при инициализации libfifo";



        /// <summary>
        /// Шаблон "Имя пользователя должно содержать не менее {0} символов."
        /// </summary>
        public static string INVALIDNAME_SMALL = String.Format("Имя должно содержать не менее {0} символов.", DmsTypes.USERNAME_MIN);
        /// <summary>
        /// Шаблон "Имя пользователя должно содержать не более {0} символов."
        /// </summary>
        public static string INVALIDNAME_BIG = String.Format("Имя должно содержать не более {0} символов.", DmsTypes.USERNAME_MAX);
        /// <summary>
        /// Шаблон "Имя пользователя не должно содержать пробелов."
        /// </summary>
        public const string INVALIDNAME_SPACES = "Имя не должно содержать пробелов.";
        /// <summary>
        /// "Имя пользователя не должно содержать цифр в начале.";
        /// </summary>
        public const string INVALIDNAME_DIGIT = "Имя не должно содержать цифр в начале.";
        /// <summary>
        /// "Имя пользователя может содержать только латинские символы, цифры, знак подчеркивания."
        /// </summary>
        public const string INVALIDNAME_NONLATIN = "Имя может содержать только латинские символы, цифры, знак подчеркивания.";

        public const string DFAULT_IMG = "default.jpg";
        public const string DFAULT_BIRTH_IMG = "default.jpg";
        public const string DFAULT_PASSWORD = "111";
        public const string USER_EXISTS = "Имя пользователя {0} уже существует.";
        public const string PAGE_EXISTS = "Страница с именем {0} уже существует.";
        public const string GROUP_EXISTS = "Имя группы {0} уже существует.";
        public const string USER_NOTEXISTS = "Имя пользователя {0} не существует.";
        public const string GROUP_NOTEXISTS = "Имя пользователя {0} не существует.";
        public const string PASSWD_NOTMATCH = "Введнные пароли не совпадают.";
        public const string PASSWD_EMPTY = "Пустые пароли не разрешены.";
        public const string USER_CANDELETE = "Удалить пользователя {0}?";
        public const string PAGE_CANDELETE = "Удалить модуль {0} из списка доступных модулей?";
        public const string GROUP_CANDELETE = "Удалить группу {0}?";
        public const string NOTHING_SELECTED = "Ничего не было выбрано.";
        public const string PAGE_INFO = "Эта страница находится в стадии разработки.";
        public const string MENUITEM_NOTFOUND = "Имя модуля {0} не найдено среди пунктов главного меню.";
        public const string PAGE_CLOSED = "Страница заблокирована для всех пользователей.";
        public const string MASS_PROGECT_CANDELETE = "После удаления, данные проетка '{0}' будут недоступны. Потребуется специальная процедура восстановления. Продолжить?";
    }
}
