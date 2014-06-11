using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Xml;
using Logger.Objects;
using Logger.Objects.InnerBody;
using Logger.Objects.InnerBody.InnerDiv;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv1;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv1.InnerDiv2;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv1.InnerDiv2.InnerTable;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv1.InnerDiv2.InnerTable.InnerTr;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv3;
using Logger.Objects.InnerBody.InnerDiv.InnerDiv3.InnerDiv4;
using Logger.Objects.InnerHead;
using Logger.Util;

namespace Logger
{
    public static class Log
    {
        #region Variables and Properties

        #region Style and Script

        #region Style

        private static string _style = "/* Body style, for the entire document */\r\n" +
                                       "      body {\r\n" +
                                       "            background: #F3F3F4;\r\n" +
                                       "            color: #1E1E1F;\r\n" +
                                       "            font-family: \"Segoe UI\", Tahoma, Geneva, Verdana, sans-serif;\r\n" +
                                       "            padding: 0;\r\n" +
                                       "            margin: 0;\r\n        " +
                                       "           }\r\n\r\n" +

                                       "/* Header1 style, used for the main title */\r\n" +
                                       "        h1 {\r\n" +
                                       "            padding: 10px 0px 10px 10px;\r\n" +
                                       "            font-size: 21pt;\r\n" +
                                       "            background-color: #E2E2E2;\r\n" +
                                       "            border-bottom: 1px #C1C1C2 solid;\r\n" +
                                       "            color: #201F20;\r\n" +
                                       "            margin: 0;\r\n" +
                                       "            font-weight: normal;\r\n" +
                                       "        }\r\n\r\n" +

                                       "/* Header2 style, used for \"Overview\" and other sections */\r\n" +
                                       "        h2 {\r\n" +
                                       "            font-size: 18pt;\r\n" +
                                       "            font-weight: normal;\r\n" +
                                       "            padding: 15px 0 5px 0;\r\n" +
                                       "            margin: 0;\r\n" +
                                       "        }\r\n\r\n" +

                                       "/* Header3 style, used for sub-sections, such as project name */\r\n" +
                                       "        h3 {\r\n" +
                                       "            font-weight: normal;\r\n" +
                                       "            font-size: 15pt;\r\n" +
                                       "            margin: 0;\r\n" +
                                       "            padding: 15px 0 5px 0;\r\n" +
                                       "            background-color: transparent;\r\n" +
                                       "        }\r\n\r\n" +

                                       " /* Color all hyperlinks one color */\r\n" +
                                       "        a {\r\n" +
                                       "            color: #1382CE;\r\n" +
                                       "        }\r\n\r\n" +

                                       "/* Table styles */\r\n" +
                                       "        table {\r\n" +
                                       "            border-spacing: 0 0;\r\n" +
                                       "            border-collapse: collapse;\r\n" +
                                       "            font-size: 10pt;\r\n" +
                                       "              }\r\n\r\n" +
                                       "            table th {\r\n" +
                                       "                background: #E7E7E8;\r\n" +
                                       "                text-align: left;\r\n" +
                                       "                text-decoration: none;\r\n" +
                                       "                font-weight: normal;\r\n" +
                                       "                padding: 3px 6px 3px 6px;\r\n" +
                                       "            }\r\n\r\n" +
                                       "            table td {\r\n" +
                                       "                vertical-align: top;\r\n" +
                                       "                padding: 3px 6px 5px 5px;\r\n" +
                                       "                margin: 0px;\r\n" +
                                       "                border: 1px solid #E7E7E8;\r\n" +
                                       "                background: #F7F7F8;\r\n" +
                                       "            }\r\n\r\n" +

                                       "/* Local link is a style for hyperlinks that link to file:/// content, there are lots so color them as 'normal' text until the user mouse overs */\r\n" +
                                       "        .localLink {\r\n" +
                                       "            color: #1E1E1F;\r\n" +
                                       "            background: #EEEEED;\r\n" +
                                       "            text-decoration: none;\r\n" +
                                       "        }\r\n\r\n" +
                                       "            .localLink:hover {\r\n" +
                                       "                color: #1382CE;\r\n" +
                                       "                background: #FFFF99;\r\n" +
                                       "                text-decoration: none;\r\n" +
                                       "            }\r\n\r\n" +
                                       "/* Center text, used in the over views cells that contain message level counts */\r\n" +
                                       "        .textCentered {\r\n" +
                                       "            text-align: center;\r\n" +
                                       "        }\r\n\r\n" +
                                       "/* The message cells in message tables should take up all avaliable space */\r\n" +
                                       "        .messageCell {\r\n" +
                                       "            width: 100%;\r\n" +
                                       "        }\r\n\r\n" +
                                       "/* Padding around the content after the h1 */\r\n" +
                                       "        #content {\r\n" +
                                       "            padding: 0px 12px 12px 12px;\r\n" +
                                       "        }\r\n\r\n" +
                                       "/* The overview table expands to width, with a max width of 97% */\r\n" +
                                       "        #overview table {\r\n" +
                                       "            width: auto;\r\n" +
                                       "            max-width: 75%;\r\n" +
                                       "        }\r\n\r\n" +
                                       "/* The messages tables are always 97% width */\r\n" +
                                       "        #messages table {\r\n" +
                                       "            width: 97%;\r\n" +
                                       "        }\r\n\r\n" +
                                       "        /* All Icons */\r\n" +
                                       "        .IconSuccessEncoded, .IconInfoEncoded, .IconWarningEncoded, .IconErrorEncoded {\r\n" +
                                       "            min-width: 18px;\r\n" +
                                       "            min-height: 18px;\r\n" +
                                       "            background-repeat: no-repeat;\r\n" +
                                       "            background-position: center;\r\n" +
                                       "        }\r\n\r\n" +

                                       "/* Success icon encoded */\r\n" +
                                       "        .IconSuccessEncoded {\r\n" +
                                       "            /* Note: Do not delete the comment below. It is used to verify the correctness of the encoded image resource below before the product is released */\r\n" +
                                       "            /* [---XsltValidateInternal-Base64EncodedImage:IconSuccess#Begin#background-image: url(data:image/png;base64,#Separator#);#End#] */\r\n" +
                                       "            background-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAACXBIWXMAAA7EAAAOxAGVKw4bAAABOElEQVR4XqVTIWvDQBh9HVWBwWzEYGow19KpQiBqrqKiYqpVkf0BcTX9ASdr2jBZMRFRe1CYysjcYDAoTIS5wCB6eXAXsjt2YezBme/73vfeF156MFBV1QLAHEBotCSAxPO8HVo4axGv6pfnn/k2lnEYPARoP9bY4wxnoUAHUIV8/bS+OLwf4MLsZobl7bIEMKzdnLSDR5GJTjKxf92Ds+SAJ/Dm2tqAjd8wuZ4gizKk92mzhBxy6WDOggvRKAKxed78cEIuF4THj6NT3T/3UXwVSN9SaChOyAV/ULfRhwHeScWVXIEw1C2YDqiklTvV9QIZXAZQoBIVqexUVxzJBQnDYbuAU11xEp1EpnBgBcmdxpc6iUOdxGk8jkvDSVeUp81HZKaZbW4Vd0LdZ9/MHmc4qzj49+/8DReTp9S7vY7uAAAAAElFTkSuQmCC);\r\n" +
                                       "        }\r\n\r\n" +
                                       "/* Information icon encoded */\r\n" +
                                       "        .IconInfoEncoded {\r\n" +
                                       "            /* Note: Do not delete the comment below. It is used to verify the correctness of the encoded image resource below before the product is released */\r\n" +
                                       "            /* [---XsltValidateInternal-Base64EncodedImage:IconInformation#Begin#background-image: url(data:image/png;base64,#Separator#);#End#] */\r\n" +
                                       "            background-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAACXBIWXMAAA7EAAAOxAGVKw4bAAABBElEQVR4Xs2TsYrCQBCG1wVFo3DXWHkHNvZJIdem8AXiA5i8xRXWFvcWiVibF7BIKxamtwmolY2FxsNrnF9GiVkSCGnuh2GL2e9nZvm3IlKK49ihw6YyU62AytM0zU0ClQTYpcNfHv50d3MRi/31hR50asLpNcRXuxoSYJFRxAZPeP29Or3Po1+RJ5iM9eaRMAMmkhv+JDwr8G70ea+kMB3uggEosfNj7BwpJmDAYgI7C/6YblGZJmBhYKYfTF1BFTOmFCX1PwwChKSomAlg4CEcRcWMJ5FtxHPYrReCwYCVDFg//dYRjcwcqFG2no/IH8OgRjgz33g/dWf0cAd3mRGlv/MNZL1xS4xD8eEAAAAASUVORK5CYII=);\r\n" +
                                       "        }\r\n\r\n" +
                                       "/* Warning icon encoded */\r\n" +
                                       "        .IconWarningEncoded {\r\n" +
                                       "            /* Note: Do not delete the comment below. It is used to verify the correctness of the encoded image resource below before the product is released */\r\n" +
                                       "            /* [---XsltValidateInternal-Base64EncodedImage:IconWarning#Begin#background-image: url(data:image/png;base64,#Separator#);#End#] */\r\n" +
                                       "            background-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAAx0lEQVR4XpWSMQ7CMAxFf4xAyBMLCxMrO8dhaBcuwdCJS3RJBw7SA/QGTCxdWJgiQYWKXJWKIXHIlyw5lqr34tQgEOdcBsCOx5yZK3hCCKdYXneQkh4pEfqzLfu+wVDSyyzFoJjfz9NB+pAF+eizx2Vruts0k15mPgvS6GYvpVtQhB61IB/dk6AF6fS4Ben0uIX5odtFe8Q/eW1KvFeH4e8khT6+gm5B+t3juyDt7n0jpe+CANTd+oTUjN/U3yVaABnSUjFz/gFq44JaVSCXeQAAAABJRU5ErkJggg==);\r\n" +
                                       "        }\r\n\r\n" +
                                       "/* Error icon encoded */\r\n" +
                                       "        .IconErrorEncoded {\r\n" +
                                       "            /* Note: Do not delete the comment below. It is used to verify the correctness of the encoded image resource below before the product is released */\r\n" +
                                       "            /* [---XsltValidateInternal-Base64EncodedImage:IconError#Begin#background-image: url(data:image/png;base64,#Separator#);#End#] */\r\n" +
                                       "            background-image: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAACXBIWXMAAA7EAAAOxAGVKw4bAAABP0lEQVR4XqWTvUoDQRSFr4NBWRAD+gA+gMXmDWJlFbC3iCBY2Qm2YmttKyhYaaFtGiPY2CWFD2BjEwiugkv8XecbcmHmEgTJgUs2371ndmY4OyNGZVluedD21TStW19nWZadKrDGFV+915tONdhsVU/LkhSMHjPMqi/sYAx6b3s79Y/Lc/lLc9u7kh0cFR40/G4e3ZhflYf7wVxbzUNZKX8/ORZm8cAdZ/66v8tpYFy67lLJIpYziwev48JGHsRyi3UdVnNgsfDg5fzpZTXz6rt4rhC/0TO9ZBbvrBh9PvRluLGWvPXnpYCFnpWTKWUXiM/Mm6n4TiYGqKvBMefn/0SmwcLriOe8D4fKnlnvBBYLD15NIinMNUjIXFjMNY19n8RGEmUSRkj+HWUeAKy6cNGR2npLrGD0mFEzfOrP+Rf4+xT8EskwMAAAAABJRU5ErkJggg==);\r\n" +
                                       "        }";
        #endregion

        #region Script

        private static string _script = "       //Startup\r\n" +
                                        "       //Hook up the the loaded event for the document/window, to linkify the document content\r\n" +
                                        "       var startupFunction = function () { linkifyElement(\"messages\"); };\r\n        " +

                                        "       if (window.attachEvent) {\r\n" +
                                        "            window.attachEvent('onload', startupFunction);\r\n" +
                                        "        }\r\n        else if (window.addEventListener) {\r\n" +
                                        "            window.addEventListener('load', startupFunction, false);\r\n" +
                                        "        }\r\n" +
                                        "        else {\r\n" +
                                        "            document.addEventListener('load', startupFunction, false);\r\n" +
                                        "        }\r\n" +

                                        "        // Toggles the visibility of table rows with the specified name\r\n" +
                                        "        function toggleTableRowsByName(name) {\r\n" +
                                        "            var allRows = document.getElementsByTagName('tr');\r\n" +
                                        "            for (i = 0; i < allRows.length; i++) {\r\n" +
                                        "                var currentName = allRows[i].getAttribute('name');\r\n" +
                                        "                if (!!currentName && currentName.indexOf(name) == 0) {\r\n" +
                                        "                    var isVisible = allRows[i].style.display == '';\r\n" +
                                        "                    isVisible ? allRows[i].style.display = 'none' : allRows[i].style.display = '';\r\n" +
                                        "                }\r\n" +
                                        "            }\r\n" +
                                        "        }\r\n\r\n" +

                                        "        function scrollToFirstVisibleRow(name) {\r\n" +
                                        "            var allRows = document.getElementsByTagName('tr');\r\n" +
                                        "            for (i = 0; i < allRows.length; i++) {\r\n" +
                                        "                var currentName = allRows[i].getAttribute('name');\r\n" +
                                        "                var isVisible = allRows[i].style.display == '';\r\n" +
                                        "                if (!!currentName && currentName.indexOf(name) == 0 && isVisible) {\r\n" +
                                        "                    allRows[i].scrollIntoView(true);\r\n" +
                                        "                    return true;\r\n" +
                                        "                }\r\n" +
                                        "            }\r\n\r\n" +
                                        "            return false;\r\n" +
                                        "        }\r\n\r\n" +

                                        "        // Linkifies the specified text content, replaces candidate links with html links\r\n" +
                                        "        function linkify(text) {\r\n" +
                                        "            if (!text || 0 === text.length) {\r\n" +
                                        "                return text;\r\n" +
                                        "            }\r\n\r\n" +
                                        "            // Find http, https and ftp links and replace them with hyper links\r\n" +
                                        "            var urlLink = /(http|https|ftp)\\:\\/\\/[a-zA-Z0-9\\-\\.]+(:[a-zA-Z0-9]*)?\\/?([a-zA-Z0-9\\-\\._\\?\\,\\/\\\\\\+&%\\$#\\=~;\\{\\}])*/gi;\r\n\r\n" +
                                        "            return text.replace(urlLink, '<a href=\"$&\">$&</a>');\r\n" +
                                        "        }\r\n\r\n" +

                                        "        // Linkifies the specified element by ID\r\n" +
                                        "        function linkifyElement(id) {\r\n" +
                                        "            var element = document.getElementById(id);\r\n" +
                                        "            if (!!element) {\r\n" +
                                        "                element.innerHTML = linkify(element.innerHTML);\r\n" +
                                        "            }\r\n" +
                                        "        }\r\n\r\n" +

                                        "        function ToggleMessageVisibility(projectName) {\r\n" +
                                        "            if (!projectName || 0 === projectName.length) {\r\n" +
                                        "                return;\r\n" +
                                        "            }\r\n\r\n" +
                                        "            toggleTableRowsByName(\"MessageRowClass\" + projectName);\r\n" +
                                        "            toggleTableRowsByName('MessageRowHeaderShow' + projectName);\r\n" +
                                        "            toggleTableRowsByName('MessageRowHeaderHide' + projectName);\r\n" +
                                        "        }\r\n\r\n" +

                                        "        function ToggleErrorVisibility(projectName) {\r\n" +
                                        "            if (!projectName || 0 === projectName.length) {\r\n" +
                                        "                return;\r\n" +
                                        "            }\r\n\r\n" +
                                        "            toggleTableRowsByName(\"ErrorRowClass\" + projectName);\r\n" +
                                        "            toggleTableRowsByName('ErrorRowHeaderShow' + projectName);\r\n" +
                                        "            toggleTableRowsByName('ErrorRowHeaderHide' + projectName);\r\n" +
                                        "        }\r\n\r\n" +

                                        "        function ToggleWarningVisibility(projectName) {\r\n" +
                                        "            if (!projectName || 0 === projectName.length) {\r\n" +
                                        "                return;\r\n" +
                                        "            }\r\n\r\n" +
                                        "            toggleTableRowsByName(\"WarningRowClass\" + projectName);\r\n" +
                                        "            toggleTableRowsByName('WarningRowHeaderShow' + projectName);\r\n" +
                                        "            toggleTableRowsByName('WarningRowHeaderHide' + projectName);\r\n" +
                                        "        }\r\n\r\n" +

                                        "        function ToggleSuccessVisibility(projectName) {\r\n" +
                                        "            if (!projectName || 0 === projectName.length) {\r\n" +
                                        "                return;\r\n" +
                                        "            }\r\n\r\n" +
                                        "            toggleTableRowsByName(\"SuccessRowClass\" + projectName);\r\n" +
                                        "            toggleTableRowsByName('SuccessRowHeaderShow' + projectName);\r\n" +
                                        "            toggleTableRowsByName('SuccessRowHeaderHide' + projectName);\r\n" +
                                        "        }\r\n\r\n" +

                                        "        function ScrollToFirstVisibleRow(projectName, typeString) {\r\n" +
                                        "            if (!projectName || 0 === projectName.length) {\r\n" +
                                        "                return;\r\n" +
                                        "            }\r\n\r\n" +
                                        "            // First try the 'Show messages' row\r\n" +
                                        "            if (!scrollToFirstVisibleRow(typeString + 'RowHeaderShow' + projectName)) {\r\n" +
                                        "                // Failed to find a visible row for 'Show messages', try an actual message row\r\n" +
                                        "                scrollToFirstVisibleRow(typeString + 'RowClass' + projectName);\r\n" +
                                        "            }\r\n" +
                                        "        }";

        #endregion

        #endregion

        private static List<Exception> _exceptions = new List<Exception>();
        private static List<string> _warnings = new List<string>();
        private static List<string> _messages = new List<string>();
        private static List<string> _success = new List<string>();
        private static string _projectName = "ProjectName";
        private static string _folder = Directory.GetCurrentDirectory();
        private static string _fileName = @"\Log_" + DateTime.Now.ToString("dd_MM_yy") + ".htm";
        private static string _header = "Log " + DateTime.Now.ToString("g");
        private static string _title = "Log";

        #region Properties

        /// <summary>
        /// A <code>List</code> of <code>Exceptions</code> to be logged.
        /// </summary>
        public static List<Exception> Exceptions
        {
            get { return _exceptions; }
            set { _exceptions = value; }
        }

        /// <summary>
        /// A <code>List</code> of Warnings to be logged.
        /// </summary>
        public static List<string> Warnings
        {
            get { return _warnings; }
            set { _warnings = value; }
        }

        /// <summary>
        /// A <code>List</code> of Messages to be logged.
        /// </summary>
        public static List<string> Messages
        {
            get { return _messages; }
            set { _messages = value; }
        }

        /// <summary>
        /// A <code>List</code> of Successes to be logged.
        /// </summary>
        public static List<string> Successes
        {
            get { return _success; }
            set { _success = value; }
        }

        /// <summary>
        /// The project name. Default is "ProjectName".
        /// </summary>
        public static string ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        /// <summary>
        /// The destination folder of the log. Default is the <code>CurrentDirectory()</code>.
        /// </summary>
        public static string Folder
        {
            get { return _folder; }
            set { _folder = value; }
        }

        /// <summary>
        /// The destination name of the log file. Default is "Log_01_02_14.htm".
        /// </summary>
        public static string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        /// <summary>
        /// The path of the project. Optional.
        /// </summary>
        public static string ProjectPath { get; set; }

        /// <summary>
        /// Title of the page, this is the browser tab title. Optional.
        /// </summary>
        public static string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// The Header text. Default is "Log";
        /// </summary>
        public static string Header
        {
            get { return _header; }
            set { _header = value; }
        }

        /// <summary>
        /// If <code>True</code>, shows all errors.
        /// <code>False</code> collapses all errros in a "Show/Hide" item.
        /// </summary>
        public static bool ExpandErrors { get; set; }

        /// <summary>
        /// If <code>True</code>, shows all warnings.
        /// <code>False</code> collapses all warnings in a "Show/Hide" item.
        /// </summary>
        public static bool ExpandWarnings { get; set; }

        /// <summary>
        /// If <code>True</code>, shows all messages.
        /// <code>False</code> collapses all messages in a "Show/Hide" item.
        /// </summary>
        public static bool ExpandMessages { get; set; }

        /// <summary>
        /// If <code>True</code>, shows all successes.
        /// <code>False</code> collapses all successes in a "Show/Hide" item.
        /// </summary>
        public static bool ExpandSuccesses { get; set; }

        /// <summary>
        /// The style of the page. Css like content. Optional.
        /// </summary>
        public static string Style
        {
            private get { return _style; }
            set { _style = value; }
        }

        /// <summary>
        /// The script of the page. Javacript content. Optional.
        /// </summary>
        public static string Script
        {
            private get { return _script; }
            set { _script = value; }
        }

        #endregion

        #endregion

        /// <summary>
        /// Creates the page and writes to disk using properties set before.
        /// </summary>
        public static void Me()
        {
            if (!Validade()) return;

            var html = new Html();

            #region Head

            html.Head = new Head();
            html.Head.Meta = new List<Meta>();
            html.Head.Meta.Add(new Meta() { Content = "en-us", HttpEquiv = "Content-Language" });
            html.Head.Meta.Add(new Meta() { Content = "text/html; charset=utf-16", HttpEquiv = "Content-Type" });
            html.Head.Title = Title;

            html.Head.Style = Style;
            html.Head.Script = Script;

            #endregion

            #region Body

            html.Body = new Body();
            html.Body.H1 = Header;
            html.Body.Div = new Div();
            html.Body.Div.Id = "content";

            #region Summary Table (Overview)

            html.Body.Div.Div1 = new Div1();
            html.Body.Div.Div1.H2 = "Overview";
            html.Body.Div.Div1.Div2 = new Div2();
            html.Body.Div.Div1.Div2.Id = "overview";
            html.Body.Div.Div1.Div2.Table = new Table();
            html.Body.Div.Div1.Div2.Table.Tr = new List<Tr>();

            #region Header

            var tableRow = new Tr();
            tableRow.Th = new List<Th>();
            tableRow.Th.Add(new Th());
            tableRow.Th.Add(new Th("ProjectTableHeader", "Project"));
            tableRow.Th.Add(new Th("PathTableHeader", "Path"));
            tableRow.Th.Add(new Th("ErrorsTableHeader", "Errors"));
            tableRow.Th.Add(new Th("WarningsTableHeader", "Warnings"));
            tableRow.Th.Add(new Th("MessagesTableHeader", "Messages"));
            tableRow.Th.Add(new Th("SuccessesTableHeader", "Successes"));
            html.Body.Div.Div1.Div2.Table.Tr.Add(tableRow);

            #endregion

            #region Project Summary

            var tableRowItem = new Tr();
            tableRowItem.Td = new List<Td>();

            #region Project Status Icon

            if (Exceptions.Any())
            {
                tableRowItem.Td.Add(new Td("IconErrorEncoded", ""));
            }
            else if (Warnings.Any())
            {
                tableRowItem.Td.Add(new Td("IconWarningEncoded", ""));
            }
            else if (Messages.Any())
            {
                tableRowItem.Td.Add(new Td("IconInfoEncoded", ""));
            }
            else
            {
                tableRowItem.Td.Add(new Td("IconSuccessEncoded", ""));
            }

            #endregion

            tableRowItem.Td.Add(new Td("", "<strong><a href=\"#" + ProjectName + "\">" + ProjectName + "</a></strong>"));
            tableRowItem.Td.Add(new Td("", ProjectPath));

            #region Counters

            #region Exceptions

            if (Exceptions.Any())
            {
                tableRowItem.Td.Add(new Td("textCentered", "<a href=\"#\" onclick=\"ScrollToFirstVisibleRow('" + ProjectName + "', 'Error'); return false;\">" + Exceptions.Count + "</a>"));
            }
            else
            {
                tableRowItem.Td.Add(new Td("textCentered", "<a>0</a>")); //If zero, no href
            }

            #endregion

            #region Warnings

            if (Warnings.Any())
            {
                tableRowItem.Td.Add(new Td("textCentered", "<a href=\"#\" onclick=\"ScrollToFirstVisibleRow('" + ProjectName + "', 'Warning'); return false;\">" + Warnings.Count + "</a>"));
            }
            else
            {
                tableRowItem.Td.Add(new Td("textCentered", "<a>0</a>")); //If zero, no href
            }

            #endregion

            #region Messages

            if (Messages.Any())
            {
                tableRowItem.Td.Add(new Td("textCentered", "<a href=\"#\" onclick=\"ScrollToFirstVisibleRow('" + ProjectName + "', 'Message'); return false;\">" + Messages.Count + "</a>"));
            }
            else
            {
                tableRowItem.Td.Add(new Td("textCentered", "<a>0</a>")); //If zero, no href
            }

            #endregion

            #region Successes

            if (Successes.Any())
            {
                tableRowItem.Td.Add(new Td("textCentered", "<a href=\"#\" onclick=\"ScrollToFirstVisibleRow('" + ProjectName + "', 'Success'); return false;\">" + Successes.Count + "</a>"));
            }
            else
            {
                tableRowItem.Td.Add(new Td("textCentered", "<a>0</a>")); //If zero, no href
            }

            #endregion

            #endregion

            html.Body.Div.Div1.Div2.Table.Tr.Add(tableRowItem);

            #endregion

            #endregion

            #region Projects

            html.Body.Div.H2 = "Details";
            html.Body.Div.Div3 = new Div3();
            html.Body.Div.Div3.Div4 = new List<Div4>();

            #region For Each Project

            var div4 = new Div4();
            div4.A = new A();
            div4.A.Name = ProjectName;
            div4.H3 = ProjectName;
            div4.Table = new Table();
            div4.Table.Tr = new List<Tr>();

            #region Header Row

            var tr = new Tr();
            tr.Id = div4.H3 + "HeaderRow";
            tr.Th = new List<Th>();
            tr.Th.Add(new Th("", "", ""));
            tr.Th.Add(new Th("MessageTableHeader", "Messages", "messageCell"));

            //First cell is empty.
            //second cell is "Messages".
            div4.Table.Tr.Add(tr);

            #endregion

            #region For each Error/Warning/Message/Success

            #region Errors

            foreach (Exception exce in Exceptions)
            {
                var trException = new Tr();

                if (!ExpandErrors)
                {
                    trException.Style = "display: none";
                }

                trException.Name = "ErrorRowClass" + ProjectName;
                trException.Td = new List<Td>();
                trException.Td.Add(new Td("IconErrorEncoded", "<a name=\"" + ProjectName + "Error\" />"));
                trException.Td.Add(new Td("messageCell", "<span>" + exce.Message + "<br><code>" + exce.StackTrace + "</code>" + "</span>"));

                div4.Table.Tr.Add(trException);
            }

            #region Show/Hide

            if (Exceptions.Count > 0 && !ExpandErrors)
            {
                #region Singular/Plural

                string singularPlural = "error";
                if (Exceptions.Count > 1)
                {
                    singularPlural += "s";
                }

                #endregion

                var trShow = new Tr();
                trShow.Name = "ErrorRowHeaderShow" + ProjectName;
                trShow.Td = new List<Td>();
                trShow.Td.Add(new Td("IconErrorEncoded", "<a name=\" " + div4.H3 + "Error\" />", "rgb(242,255,255)"));
                trShow.Td.Add(new Td("messageCell", "<a _locid=\"ShowAdditionalErrors\" href=\"#\" name=\"" + ProjectName + "Error\" onclick=\"ToggleErrorVisibility('" + ProjectName + "'); return false;\">Show " + Exceptions.Count + " " + singularPlural + "</a>", "background-color: rgb(239,245,249);"));

                div4.Table.Tr.Add(trShow);

                var trHide = new Tr();
                trHide.Name = "ErrorRowHeaderHide" + ProjectName;
                trHide.Style = "display: none";
                trHide.Td = new List<Td>();
                trHide.Td.Add(new Td("IconErrorEncoded", "<a name=\" " + div4.H3 + "Error\" />", "rgb(242,255,255)"));
                trHide.Td.Add(new Td("messageCell", "<a _locid=\"HideAdditionalErrors\" href=\"#\" name=\"" + ProjectName + "Error\" onclick=\"ToggleErrorVisibility('" + ProjectName + "'); return false;\">Hide " + Exceptions.Count + " " + singularPlural + "</a>", "background-color: rgb(239,245,249);"));

                div4.Table.Tr.Add(trHide);
            }

            #endregion

            #endregion

            #region Warnings

            foreach (string warning in Warnings)
            {
                var trWarnings = new Tr();

                if (!ExpandWarnings)
                {
                    trWarnings.Style = "display: none";
                }

                trWarnings.Name = "WarningRowClass" + ProjectName;
                trWarnings.Td = new List<Td>();
                trWarnings.Td.Add(new Td("IconWarningEncoded", "<a name=\"" + ProjectName + "Warning\" />"));
                trWarnings.Td.Add(new Td("messageCell", "<span>" + warning + "</span>"));

                div4.Table.Tr.Add(trWarnings);
            }

            #region Show/Hide

            if (Warnings.Count > 0 && !ExpandWarnings)
            {
                #region Singular/Plural

                string singularPlural = "warning";
                if (Warnings.Count > 1)
                {
                    singularPlural += "s";
                }

                #endregion

                var trShow = new Tr();
                trShow.Name = "WarningRowHeaderShow" + ProjectName;
                trShow.Td = new List<Td>();
                trShow.Td.Add(new Td("IconWarningEncoded", "<a name=\" " + div4.H3 + "Warning\" />", "rgb(242,255,255)"));
                trShow.Td.Add(new Td("messageCell", "<a _locid=\"ShowAdditionalWarnings\" href=\"#\" name=\"" + ProjectName + "Error\" onclick=\"ToggleWarningVisibility('" + ProjectName + "'); return false;\">Show " + Warnings.Count + " " + singularPlural + "</a>", "background-color: rgb(239,245,249);"));

                div4.Table.Tr.Add(trShow);

                var trHide = new Tr();
                trHide.Name = "WarningRowHeaderHide" + ProjectName;
                trHide.Style = "display: none";
                trHide.Td = new List<Td>();
                trHide.Td.Add(new Td("IconWarningEncoded", "<a name=\" " + div4.H3 + "Warning\" />", "rgb(242,255,255)"));
                trHide.Td.Add(new Td("messageCell", "<a _locid=\"HideAdditionalWarnings\" href=\"#\" name=\"" + ProjectName + "Error\" onclick=\"ToggleWarningVisibility('" + ProjectName + "'); return false;\">Hide " + Warnings.Count + " " + singularPlural + "</a>", "background-color: rgb(239,245,249);"));

                div4.Table.Tr.Add(trHide);
            }

            #endregion

            #endregion

            #region Messages

            foreach (string message in Messages)
            {
                var trMessages = new Tr();

                if (!ExpandMessages)
                {
                    trMessages.Style = "display: none";
                }

                trMessages.Name = "MessageRowClass" + ProjectName;
                trMessages.Td = new List<Td>();
                trMessages.Td.Add(new Td("IconInfoEncoded", "<a name=\"" + ProjectName + "Message\" />"));
                trMessages.Td.Add(new Td("messageCell", "<span>" + message + "</span>"));

                div4.Table.Tr.Add(trMessages);
            }

            #region Show/Hide

            if (Messages.Count > 0 && !ExpandMessages)
            {
                #region Singular/Plural

                string singularPlural = "message";
                if (Messages.Count > 1)
                {
                    singularPlural += "s";
                }

                #endregion

                var trShow = new Tr();
                trShow.Name = "MessageRowHeaderShow" + ProjectName;
                trShow.Td = new List<Td>();
                trShow.Td.Add(new Td("IconInfoEncoded", "<a name=\" " + div4.H3 + "Message\" />", "rgb(242,255,255)"));
                trShow.Td.Add(new Td("messageCell", "<a _locid=\"ShowAdditionalMessages\" href=\"#\" name=\"" + ProjectName + "Message\" onclick=\"ToggleMessageVisibility('" + ProjectName + "'); return false;\">Show " + Messages.Count + " " + singularPlural + "</a>", "background-color: rgb(239,245,249);"));

                div4.Table.Tr.Add(trShow);

                var trHide = new Tr();
                trHide.Name = "MessageRowHeaderHide" + ProjectName;
                trHide.Style = "display: none";
                trHide.Td = new List<Td>();
                trHide.Td.Add(new Td("IconInfoEncoded", "<a name=\" " + div4.H3 + "Message\" />", "rgb(242,255,255)"));
                trHide.Td.Add(new Td("messageCell", "<a _locid=\"HideAdditionalMessages\" href=\"#\" name=\"" + ProjectName + "Message\" onclick=\"ToggleMessageVisibility('" + ProjectName + "'); return false;\">Hide " + Messages.Count + " " + singularPlural + "</a>", "background-color: rgb(239,245,249);"));

                div4.Table.Tr.Add(trHide);
            }

            #endregion

            #endregion

            #region Successes

            foreach (string success in Successes)
            {
                var trSuccesses = new Tr();

                if (!ExpandSuccesses)
                {
                    trSuccesses.Style = "display: none";
                }

                trSuccesses.Name = "SuccessRowClass" + ProjectName;
                trSuccesses.Td = new List<Td>();
                trSuccesses.Td.Add(new Td("IconSuccessEncoded", "<a name=\"" + ProjectName + "Success\" />"));
                trSuccesses.Td.Add(new Td("messageCell", "<span>" + success  +"</span>"));

                div4.Table.Tr.Add(trSuccesses);
            }

            #region Show/Hide

            if (Successes.Count > 0 && !ExpandSuccesses)
            {
                #region Singular/Plural

                string singularPlural = "success";
                if (Successes.Count > 1)
                {
                    singularPlural += "es";
                }

                #endregion

                var trShow = new Tr();
                trShow.Name = "SuccessRowHeaderShow" + ProjectName;
                trShow.Td = new List<Td>();
                trShow.Td.Add(new Td("IconSuccessEncoded", "<a name=\" " + div4.H3 + "Success\" />", "rgb(242,255,255)"));
                trShow.Td.Add(new Td("messageCell", "<a _locid=\"ShowAdditionalSuccesses\" href=\"#\" name=\"" + ProjectName + "Success\" onclick=\"ToggleSuccessVisibility('" + ProjectName + "'); return false;\">Show " + Successes.Count + " " + singularPlural + "</a>", "background-color: rgb(239,245,249);"));

                div4.Table.Tr.Add(trShow);

                var trHide = new Tr();
                trHide.Name = "SuccessRowHeaderHide" + ProjectName;
                trHide.Style = "display: none";
                trHide.Td = new List<Td>();
                trHide.Td.Add(new Td("IconSuccessEncoded", "<a name=\" " + div4.H3 + "Success\" />", "rgb(242,255,255)"));
                trHide.Td.Add(new Td("messageCell", "<a _locid=\"HideAdditionalSuccesses\" href=\"#\" name=\"" + ProjectName + "Success\" onclick=\"ToggleSuccessVisibility('" + ProjectName + "'); return false;\">Hide " + Successes.Count + " " + singularPlural + "</a>", "background-color: rgb(239,245,249);"));

                div4.Table.Tr.Add(trHide);
            }

            #endregion

            #endregion

            #endregion

            html.Body.Div.Div3.Div4.Add(div4);

            #endregion

            #endregion

            #endregion

            #region Serialize

            XmlDocument doc = XmlUtils.Serializar<Html>(html);
            string xmltext = XmlUtils.GetXmlTexto(doc);

            #endregion

            #region Replace's

            xmltext = "<!DOCTYPE html>\r\n" +
                      "<!-- saved from url=(0014)about:internet -->\r\n" + xmltext;
            xmltext = xmltext.Replace("&lt;", "<").Replace("&gt;", ">").Replace("&amp;", "&");
            xmltext = xmltext.Replace("<html>", "<html xmlns:msxsl=\"urn:schemas-microsoft-com:xslt\">\r\n").Replace("<script>", "<script type=\"text/javascript\" language=\"javascript\">").Replace("<value>", "").Replace("</value>", "");

            #endregion

            File.WriteAllText(Folder + FileName, xmltext);
        }

        /// <summary>
        /// Creates the log and clean the variables.
        /// </summary>
        public static void MeAndClean()
        {
            Me();
            Clean();
        }

        /// <summary>
        /// Clean the variables.
        /// </summary>
        public static void Clean()
        {
            Exceptions = new List<Exception>();
            Warnings = new List<string>();
            Messages = new List<string>();
            Successes = new List<string>();

            ProjectName = "ProjectName";
            Folder = Directory.GetCurrentDirectory();
            FileName = @"\Log_" + DateTime.Now.ToString("dd_MM_yy") + ".htm";
            Header = "Log " + DateTime.Now.ToString("g");
            Title = "Log";

            ExpandErrors = false;
            ExpandWarnings = false;
            ExpandMessages = false;
            ExpandSuccesses = false;
        }

        /// <summary>
        /// Add an Exception.
        /// </summary>
        /// <param name="exc">This Exception.</param>
        /// <param name="value">New value to be added to a <code>new Exception()</code> constructor.</param>
        public static void Add(this List<Exception> exc, string value)
        {
            exc.Add(new Exception(value));
        }

        /// <summary>
        /// Validade the properties.
        /// </summary>
        internal static bool Validade()
        {
            if (!(Exceptions.Any() || Warnings.Any() || Messages.Any() || Successes.Any()))
            {
                //throw new ArgumentException("At least one Exception/Warning/Message/Success expected.");
                return false;
            }

            if (String.IsNullOrEmpty(ProjectName))
            {
                throw new ArgumentException("Project name must be declared.");
            }

            if (String.IsNullOrEmpty(Folder))
            {
                throw new ArgumentException("You must inform the Folder wich the Log will be writen.");
            }

            if (!Directory.Exists(Folder))
            {
                Directory.CreateDirectory(Folder);
            }

            if (!FileName.StartsWith("\\"))
            {
                FileName = "\\" + FileName;
            }

            if (!FileName.EndsWith(".htm"))
            {
                FileName += ".htm";
            }

            return true;
        }
    }
}
