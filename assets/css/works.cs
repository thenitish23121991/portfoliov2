* {
  margin: 0px;
  padding: 0px; }

/* Goqii Colors */
/* Studycopter Colors */
/* Mycarapp Colors */
/* Studycopter Book Colors */
@font-face {
  src: url("../fonts/Gotham-XLight.ttf");
  font-family: "GothamXLight"; }
@font-face {
  src: url("../fonts/untitled-font-19.ttf");
  font-family: "untitled-font-19"; }
@font-face {
  src: url("../fonts/Futura-Light.ttf");
  font-family: "FuturaLight"; }
@font-face {
  src: url("../fonts/neue_haas.ttf");
  font-family: "NeueHaas"; }
@font-face {
  src: url("../fonts/Futura PT Heavy.ttf");
  font-family: "FuturaPTHeavy"; }
@font-face {
  src: url("../fonts/Futura PT Book.otf");
  font-family: "FuturaPTBook"; }
@font-face {
  src: url("../fonts/futura-pt-light.otf");
  font-family: "FuturaPTLight"; }
@font-face {
  src: url("../fonts/Futura PT Heavy.ttf");
  font-family: "FuturaPTHeavy"; }
@font-face {
  src: url("../fonts/MercuryTextG1-Roman.otf");
  font-family: "MercuryText"; }
@font-face {
  src: url("../fonts/Futura-Thin.woff");
  font-family: "FuturaThin"; }
@font-face {
  src: url("../fonts/freight-text-book.ttf");
  font-family: "FreightText"; }
@font-face {
  src: url("../fonts/Leitura News Roman.otf");
  font-family: "LeituraNews"; }
html, body {
  height: 100%;
  width: 100%; }

.overlay {
  position: absolute;
  top: 0px;
  left: 0px;
  height: 100%;
  width: 100%;
  background-color: rgba(52, 13, 123, 0.65);
  z-index: 12; }

.clear {
  clear: both; }

#slide_content_container {
  position: absolute;
  top: 14%;
  left: 4%; }

.container {
  height: 100%;
  width: 100%;
  position: relative; }

#first_slide {
  height: 100%;
  width: 100%;
  overflow: hidden;
  background-image: url("../images/home_background.jpg");
  background-size: cover;
  position: relative; }

#second_slide {
  min-height: 100%;
  width: 100%;
  background: #fff;
  overflow: hidden;
  position: relative; }

.work_cover {
  position: relative;
  background-size: cover; }

#work_cover1 {
  width: 100%;
  height: 420px; }

#work_section1 {
  position: relative;
  width: 100%;
  height: 420px;
  background-image: url("../images/sureshot_larger.jpg");
  background-size: cover; }

.work_section {
  position: relative; }

.work_overlay {
  position: absolute;
  top: 0px;
  left: 0px;
  height: 100%;
  width: 100%;
  background-color: rgba(241, 46, 52, 0.75); }

#work_cover1 .work_overlay {
  background: rgba(255, 212, 72, 0.55); }

#work_cover2 .work_overlay {
  background: rgba(81, 45, 168, 0.55); }

#work_cover3 .work_overlay {
  background: rgba(62, 136, 237, 0.55); }

#work_cover4 .work_overlay {
  background: rgba(34, 217, 108, 0.55); }

#work_cover5 .work_overlay {
  background: #f3f3f3; }

#work_cover4, #work_cover5 {
  height: 420px;
  width: 50%;
  float: left; }

#work_cover5 .work_overlay {
  background: #f3f3f3; }

.work_section_title {
  font-family: "FuturaPTLight";
  font-size: 84px;
  color: #fff;
  text-align: center; }

.work_section_desc {
  text-align: center;
  font-family: "FuturaPTLight";
  font-size: 25.8px;
  margin-top: 24px;
  color: #fff; }

.work_cover .work_overlay .work_section_title {
  margin-top: 10%; }

#work_cover4 .work_overlay .work_section_title, #work_cover5 .work_overlay .work_section_title {
  margin-top: 20%; }

#work_cover2 .work_overlay .work_section_title, #work_cover3 .work_overlay .work_section_title {
  margin-top: 20%; }

#work_section2 {
  height: 420px;
  width: 100%; }

#work_section3 {
  height: 420px;
  width: 100%; }

#work_cover2, #work_cover3 {
  width: 50%;
  height: 420px; }

#work_cover2 {
  background-image: url("../images/mycarapp_cover.jpg.png");
  float: left; }

#work_cover3 {
  background-image: url("../images/goqii_illustration.jpg");
  background-size: cover;
  float: left; }

#work_cover4 {
  background-image: url("../images/studycopter_cover.png"); }

.intro_name {
  font-family: "FuturaPTLight";
  font-size: 54px;
  color: #111; }

.intro_line {
  font-family: "FuturaPTLight";
  font-size: 48px;
  color: #111; }

.intro_name, .intro_line {
  padding: 23px 12px 17px 12px;
  background: #ffffff;
  font-family: "FuturaPTLight";
  font-size: 48px; }

.intro_buttons {
  margin-top: 48px;
  width: 100%;
  text-align: center; }

.intro_button {
  height: 48px;
  width: 48px;
  border-radius: 27px;
  display: inline-block;
  margin-left: 8px;
  background: #3b5998;
  position: relative; }

a:nth-child(1) .intro_button {
  margin-left: 0px;
  background: #1769ff; }

a:nth-child(2) .intro_button {
  background: #4078c0; }

a:nth-child(3) .intro_button {
  background: #0077b5; }

a:nth-child(4) .intro_button {
  background: #00ab6b; }

.intro_button:before {
  position: absolute;
  top: 14.1px;
  left: 16px;
  color: #fff;
  font-family: "untitled-font-19";
  font-size: 16.5px; }

.intro_buttons a:nth-child(1) .intro_button:before {
  content: "k";
  font-size: 17.5px; }

.intro_buttons a:nth-child(2) .intro_button:before {
  content: "m";
  top: 15.7px; }

.intro_buttons a:nth-child(3) .intro_button:before {
  content: "n";
  font-size: 14.6px;
  top: 15.8px;
  left: 16.7px; }

.intro_buttons a:nth-child(4) .intro_button:before {
  font-size: 14.2px;
  top: 18.1px;
  left: 17.3px;
  content: "q"; }

.intro_buttons a {
  margin-left: 12px; }

#third_slide {
  background: #fff;
  min-height: 320px;
  width: 100%; }

.contact_container {
  width: 100%; }

.contact_text {
  width: 70%;
  padding: 48px 15% 22px 15%;
  font-family: "FuturaPTLight";
  font-size: 46px;
  color: #000;
  text-align: center; }

.contact_content {
  width: 80%;
  margin: 18px 10%; }

.contact_single {
  float: left;
  width: 33.3%; }

.contact_content {
  font-family: "FuturaPTLight";
  font-size: 26.5px;
  color: #000;
  text-align: center; }

.contact_email {
  font-family: "FuturaPTLight";
  font-size: 35px;
  color: #1ebcff; }

.skyline {
  position: absolute;
  bottom: 0px;
  left: 0px;
  background: #111;
  height: 0px;
  width: 8px; }

.first_square {
  height: 72px;
  width: 72px;
  background: #e3cf8a;
  position: absolute;
  top: 270px;
  left: 650px; }

.first_square:nth-child(2) {
  top: 342px;
  -webkit-transform: scale(0);
  -webkit-transition: all 0.29s cubic-bezier(0.02, 1, 0.69, 0.97) 0s; }

.first_square:nth-child(3) {
  top: 384px; }

.first_square:nth-child(4) {
  top: 456px; }

.first_square:nth-child(5) {
  top: 528px; }

.first_square:nth-child(6) {
  top: 600px; }

.first_square:nth-child(7) {
  top: 240px; }

.first_square:nth-child(8) {
  top: 168px; }

.first_square:nth-child(9) {
  top: 96px; }

.first_square:nth-child(10) {
  top: 24px; }

.first_square:nth-child(11) {
  top: -42px; }

.first_square.scale {
  -webkit-transform: scale(1); }

.work_cover a {
  display: block; }

.home_menu {
  width: 60%; }

.home_menu ul {
  list-style-type: none; }

.home_menu ul li {
  font-family: 'FuturaPTLight';
  font-size: 27.5px;
  margin-left: 54px;
  float: left;
  cursor: pointer;
  color: #fff; }

.home_menu ul li.list_active {
  color: lightgray; }

.home_menu ul li a {
  text-decoration: none;
  color: inherit; }

.home_menu ul li:nth-child(1) {
  margin-left: 0px; }

.intro_name_container {
  clear: left; }

.works_cover {
  cursor: pointer; }

#work_cover5 .work_section_title, #work_cover5 .work_section_desc {
  color: rgba(0, 0, 0, 0.8); }

.home_top_container {
  position: absolute;
  top: 0px;
  left: 0px;
  height: 100%;
  width: 100%;
  background: none;
  background-size: cover;
  background-position: 0px 0px; }

.works_cover {
  cursor: pointer; }

#svg_container, #Layer_1 {
  position: absolute;
  top: 0px;
  left: 0px;
  height: 100%;
  width: 100%;
  z-index: 20; }

#home_content_container {
  position: absolute;
  top: 2%;
  left: 7%;
  height: 100%;
  width: 100%;
  padding: 3% 13% 0% 6%;
  z-index: 100; }

#svg_container g polygon, #Layer_1 g polygon {
  transition: all 2s ease-out 0s;
  -webkit-transition: all 2s ease-out 0s; }

.intro_line_container {
  padding-top: 24px;
  text-align: left;
  width: 76%;
  margin: 24px 0%;
  opacity: 0;
  transform: translateX(-110px);
  -webkit-transform: translateX(-110px);
  -moz-transform: translateX(-110px);
  -ms-transform: translateX(-110px); }

.intro_name_container {
  padding-top: 10%;
  text-align: left;
  width: 60%;
  opacity: 0;
  transform: translateX(-110px);
  -webkit-transform: translateX(-110px);
  -moz-transform: translateX(-110px);
  -ms-transform: translateX(-110px);
  transition: all .5s ease-out 0s;
  -webkit-transition: opacity .6s ease-out .1s, -webkit-transform .55s ease-out .1s;
  -moz-transition: all .5s ease-out 0s;
  -ms-transition: all .5s ease-out 0s; }

.intro_name_container.show, .intro_line_container.show {
  opacity: 1;
  transform: translateX(0px);
  -webkit-transform: translateX(0px);
  -moz-transform: translateX(0px);
  -ms-transform: translateX(0px); }

#intro_line_container_1 {
  transition: all .5s ease-in 0s;
  -webkit-transition: opacity .55s ease-out .23s, -webkit-transform .55s ease-out .23s;
  -moz-transition: all .5s ease-in 0s;
  -ms-transition: all .5s ease-in 0s; }

#intro_line_container_2 {
  transition: all .5s ease-in 0s;
  -webkit-transition: opacity .55s ease-out .23s, -webkit-transform .55s ease-out .36s;
  -moz-transition: all .5s ease-in 0s;
  -ms-transition: all .5s ease-in 0s; }

/*# sourceMappingURL=style4.css.map */
.works_container {
  min-height: 100%;
  width: 100%; }

#works_studycopter_book_container {
  color: #FFD448; }

#works_goqii_container {
  color: #3e88ed; }

#works_mycarapp_container {
  color: #512DA8; }

#works_studycopter_container {
  color: #22D96C; }

.works_cover_container {
  position: relative;
  width: 100%;
  height: 340px; }

.works_content_container {
  margin: 58px 0px 72px 0px;
  width: 100%; }

.works_content_container > div {
  width: 72%;
  margin-left: 14%; }

.works_content_container > div.full {
  width: 100%;
  margin-left: 0%; }

.works_content_title {
  font-family: 'FuturaPTHeavy';
  font-size: 40px;
  color: inherit; }

.works_content_text {
  font-family: "LeituraNews";
  font-style: normal;
  font-weight: 300;
  font-size: 21.9px;
  line-height: 38px;
  margin-top: 22px;
  color: rgba(0, 0, 0, 0.8); }

.works_content_text {
  font-family: "MercuryText";
  font-style: normal;
  font-weight: 300;
  font-size: 24.8px;
  line-height: 38px; }

#works_cover_1 {
  background-image: url("../images/sureshot_larger.jpg");
  background-size: cover; }

.works_overlay_title {
  margin-top: 8%;
  width: 100%;
  font-family: 'FuturaPTLight';
  font-size: 84px;
  color: #fff;
  text-align: center; }

.works_overlay_desc {
  font-family: 'FuturaPTLight';
  font-size: 32.3px;
  color: #fff;
  margin-top: 18px;
  width: 100%;
  text-align: center; }

.works_details_container {
  position: relative;
  margin-top: 42px;
  width: 84%;
  margin-left: 8%; }

.works_details_single {
  width: 44%;
  float: left;
  position: relative; }

.works_details_single:nth-child(2), .works_details_single:nth-child(3) {
  margin-left: 2.5%; }

.works_details_title {
  font-family: 'FuturaPTBook';
  color: rgba(0, 0, 0, 0.8);
  font-size: 32.1px; }

.works_details_content {
  position: relative;
  margin-top: 9px;
  font-family: 'LeituraNews';
  font-size: 20.1px;
  line-height: 32px;
  color: #000; }

.works_content_title {
  margin-top: 54px; }

.works_bottom_container {
  width: 100%; }

.bottom_single_container {
  position: relative;
  width: 50%;
  float: left;
  height: 440px;
  background-size: cover; }

.bottom_single_container .overlay {
  height: 100%;
  width: 100%; }

#works_cover_1 .overlay {
  background: rgba(255, 212, 72, 0.55); }

#works_cover_2 .overlay {
  background: rgba(62, 136, 237, 0.55); }

#works_cover_3 .overlay {
  background: rgba(81, 45, 168, 0.55); }

#works_cover_4 .overlay {
  background: rgba(34, 217, 108, 0.55); }

.bottom_single_container .overlay .work_section_title {
  margin-top: 21%; }

#bottom_single_goqii {
  background-image: url("../images/goqii_illustration.jpg"); }

#bottom_single_studycopter_book {
  background-image: url("../images/sureshot_larger.jpg"); }

#bottom_single_mycarapp {
  background-image: url("../images/mycarapp_cover.jpg.png"); }

#bottom_single_studycopter {
  background-image: url("../images/studycopter_cover.png"); }

#bottom_single_other {
  background: #f3f3f3; }

#bottom_single_other .overlay {
  background: transparent; }

#bottom_single_other .work_section_title, #bottom_single_other .work_section_desc {
  color: rgba(0, 0, 0, 0.8); }

.works_cover_container {
  background-size: cover;
  background-position: 0px -500px; }

.works_cover_container .overlay {
  background: rgba(0, 0, 0, 0.2); }

#works_cover_1 {
  background-image: url("../images/sureshot_larger.jpg"); }

#works_cover_2 {
  background-image: url("../images/goqii_illustration.jpg"); }

#works_cover_3 {
  background-image: url("../images/mycarapp_cover.jpg.png"); }

#works_cover_4 {
  background-image: url("../images/studycopter_cover.png"); }

#works_cover_3 {
  background-position: 0px -100px; }

#works_cover_4 {
  background-position: 0px -300px; }

.home_button {
  height: 56px;
  width: 56px;
  border-radius: 50%;
  background: #5129C8;
  position: fixed;
  top: 7%;
  left: 4.8%;
  z-index: 1000; }

.home_button img {
  padding: 11px 10px; }

.title_seperator {
  height: 4px;
  width: 42px;
  margin: 6px 0px;
  background: #000; }

.screens_container {
  padding: 54px 0px 32px 0px;
  background: #ececec;
  margin-top: 12px;
  text-align: center; }

.screens_title {
  font-family: 'FuturaPTLight';
  font-size: 29.5px;
  color: #282828;
  text-align: left;
  margin-left: 14%; }

.screens_seperator {
  width: 48px;
  height: 2px;
  background: #505050;
  margin-top: 12px;
  margin-left: 14%;
  display: block; }

.screens_images_container {
  margin-left: 14%;
  text-align: left; }

.screens_container img {
  margin-left: 24px;
  margin-top: 62px; }

/*
.screens_container img:nth-child(2n+1){
	margin-left:0px;
}
*/
.screens_container img:nth-child(2n+2) {
  margin-left: 48px; }

/* Theme Styles */
.theme_container {
  margin: 28px;
  width: 100%; }

.theme_color_card {
  float: left; }

.color_box {
  width: 240px;
  height: 240px; }

#works_goqii_container .theme_container.theme_container_old .theme_color_card:nth-child(1) .color_box {
  background: #3e88ed; }

#works_goqii_container .theme_container.theme_container_old .theme_color_card:nth-child(2) .color_box {
  background: #27b45a; }

#works_goqii_container .theme_container.theme_container_old .theme_color_card:nth-child(3) .color_box {
  background: #f2122b; }

#works_goqii_container .theme_container.theme_container_old .theme_color_card:nth-child(4) .color_box {
  background: #fb923b; }

#works_goqii_container .theme_container .theme_color_card:nth-child(1) .color_box {
  background: #3e88ed; }

#works_goqii_container .theme_container .theme_color_card:nth-child(2) .color_box {
  background: #25cc44; }

#works_goqii_container .theme_container .theme_color_card:nth-child(3) .color_box {
  background: #23e369; }

#works_goqii_container .theme_container .theme_color_card:nth-child(4) .color_box {
  background: #ffdb00; }

#works_studycopter_container .theme_container .theme_color_card:nth-child(1) .color_box {
  background: #22d96c; }

#works_studycopter_container .theme_container .theme_color_card:nth-child(2) .color_box {
  background: #24a357; }

#works_studycopter_container .theme_container .theme_color_card:nth-child(3) .color_box {
  background: #8d10f3; }

#works_mycarapp_container .theme_container .theme_color_card:nth-child(1) .color_box {
  background: #512da8; }

#works_mycarapp_container .theme_container .theme_color_card:nth-child(2) .color_box {
  background: #422589; }

#works_mycarapp_container .theme_container .theme_color_card:nth-child(3) .color_box {
  background: #ffdb00; }

#works_studycopter_book_container .theme_container .theme_color_card:nth-child(1) .color_box {
  background: #ffdc17; }

#works_studycopter_book_container .theme_container .theme_color_card:nth-child(2) .color_box {
  background: #521ca5; }

#works_studycopter_book_container .theme_container .theme_color_card:nth-child(3) .color_box {
  background: #37cb08; }

#works_studycopter_book_container .theme_container .theme_color_card:nth-child(4) .color_box {
  background: #3167ff; }

.typeface_container {
  margin: 22px 0px; }

/*# sourceMappingURL=works.cs.map */
