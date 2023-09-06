"use strict";(self.webpackChunkTaskManager=self.webpackChunkTaskManager||[]).push([[807],{4807:(U,u,l)=>{l.r(u),l.d(u,{PagesModule:()=>W});var g=l(6019),p=l(9652);class c{}var e=l(3556),d=l(3755),o=l(7537);let v=(()=>{class r{constructor(i,n){this.elementRef=i,this.renderer2=n}ngOnInit(){this.divElement=this.renderer2.createElement("div"),this.renderer2.setAttribute(this.divElement,"role","alert"),this.renderer2.setAttribute(this.divElement,"class","alert alert-danger fade show"),this.renderer2.setStyle(this.divElement,"transition","transform 0.5s"),this.spanElement=this.renderer2.createElement("span"),this.renderer2.setAttribute(this.spanElement,"class","message"),this.spanText=this.renderer2.createText(this.error),this.renderer2.appendChild(this.spanElement,this.spanText),this.renderer2.appendChild(this.divElement,this.spanElement),this.elementRef.nativeElement.appendChild(this.divElement),this.title="Please try again"}onMouseEnter(i){this.renderer2.setStyle(this.divElement,"transform","scale(1.1")}onMouseLeave(i){this.renderer2.setStyle(this.divElement,"transform","scale(1)")}}return r.\u0275fac=function(i){return new(i||r)(e.Y36(e.SBq),e.Y36(e.Qsj))},r.\u0275dir=e.lG2({type:r,selectors:[["","appAlert",""]],hostVars:1,hostBindings:function(i,n){1&i&&e.NdJ("mouseenter",function(a){return n.onMouseEnter(a)})("mouseleave",function(a){return n.onMouseLeave(a)}),2&i&&e.Ikx("title",n.title)},inputs:{error:"error"}}),r})();const h=["user"];function F(r,t){if(1&r&&e._UZ(0,"div",15),2&r){const i=e.oxw();e.Q6J("error",i.resultMessage)}}let Z=(()=>{class r{constructor(i,n){this.loginService=i,this.route=n,this.loginViewModel=new c,this.resultMessage=""}ngOnInit(){}onLoginClick(i){setTimeout(()=>{this.userName.nativeElement.focus(),this.loginService.Login(this.loginViewModel).subscribe({next:()=>{"Admin"===this.loginService.currentUserRole?(console.log(this.loginService.currentUserRole),this.route.navigate(["/admin","dashboard"])):(console.log(this.loginService.currentUserRole),this.route.navigate(["/employee","tasks"]))},error:n=>{console.log(n),this.resultMessage="Invalid Username or Password"}})},100)}}return r.\u0275fac=function(i){return new(i||r)(e.Y36(d.r),e.Y36(p.F0))},r.\u0275cmp=e.Xpm({type:r,selectors:[["app-login"]],viewQuery:function(i,n){if(1&i&&e.Gf(h,5),2&i){let s;e.iGM(s=e.CRH())&&(n.userName=s.first)}},decls:23,vars:3,consts:[[1,"row"],[1,"col-lg-6","col-xl-5","col-md-9","mx-auto"],[1,"card","mt-4"],[1,"card-header","bg-secondary","text-white"],["appAlert","",3,"error",4,"ngIf"],[1,"card-body"],[1,"form-group","form-row"],["for","UserName",1,"col-md-4","col-form-label"],[1,"col-md-8"],["type","text","placeholder","userName","name","UserName","autofocus","autofocus",1,"form-control",3,"ngModel","ngModelChange"],["user",""],["for","password",1,"col-md-4","col-form-label"],["type","password","placeholder","Password","name","Password",1,"form-control",3,"ngModel","ngModelChange"],[1,"card-footer","text-right"],[1,"btn","btn-primary",3,"click"],["appAlert","",3,"error"]],template:function(i,n){1&i&&(e.TgZ(0,"form"),e.TgZ(1,"div",0),e.TgZ(2,"div",1),e.TgZ(3,"div",2),e.TgZ(4,"div",3),e.TgZ(5,"h3"),e._uU(6,"Login"),e.qZA(),e.YNc(7,F,1,1,"div",4),e.qZA(),e.TgZ(8,"div",5),e.TgZ(9,"div",6),e.TgZ(10,"label",7),e._uU(11,"Username"),e.qZA(),e.TgZ(12,"div",8),e.TgZ(13,"input",9,10),e.NdJ("ngModelChange",function(a){return n.loginViewModel.UserName=a}),e.qZA(),e.qZA(),e.qZA(),e.TgZ(15,"div",6),e.TgZ(16,"label",11),e._uU(17,"Password"),e.qZA(),e.TgZ(18,"div",8),e.TgZ(19,"input",12),e.NdJ("ngModelChange",function(a){return n.loginViewModel.Password=a}),e.qZA(),e.qZA(),e.qZA(),e.qZA(),e.TgZ(20,"div",13),e.TgZ(21,"button",14),e.NdJ("click",function(a){return n.onLoginClick(a)}),e._uU(22,"Login"),e.qZA(),e.qZA(),e.qZA(),e.qZA(),e.qZA(),e.qZA()),2&i&&(e.xp6(7),e.Q6J("ngIf",n.resultMessage),e.xp6(6),e.Q6J("ngModel",n.loginViewModel.UserName),e.xp6(6),e.Q6J("ngModel",n.loginViewModel.Password))},directives:[o._Y,o.JL,o.F,g.O5,o.Fj,o.JJ,o.On,v],styles:[""]}),r})();var N=l(5517),b=l(4753);let _=(()=>{class r{constructor(i){this.loginService=i}minimumAgeValidator(i){return n=>{if(!n.value)return null;let s=new Date,a=new Date(n.value);return Math.abs(s.getTime()-a.getTime())/864e5/365.25>=i?null:{minAge:{valid:!1}}}}confirmPasswordValidator(i,n){return s=>{let a=s.get(i),f=s.get(n);return a.value&&a.value!==f.value?(a.setErrors({compareValidator:{valid:!1}}),{compareValidator:{valid:!1}}):null}}DuplicateEmailValidator(){return i=>(console.log(i.value),this.loginService.getUserByEmail(i.value).pipe((0,b.U)(n=>null!==n?(i.setErrors({uniqueEmail:{valid:!1}}),{uniqueEmail:{valid:!1}}):null)))}}return r.\u0275fac=function(i){return new(i||r)(e.LFG(d.r))},r.\u0275prov=e.Yz7({token:r,factory:r.\u0275fac,providedIn:"root"}),r})();function C(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"First name can't be blank"),e.qZA())}function T(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"First name should contain at least 3 characters"),e.qZA())}function y(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Last name can't be blank"),e.qZA())}function A(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Last name should contain at least 3 characters"),e.qZA())}function q(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Email can't be blank"),e.qZA())}function w(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Email is invalid"),e.qZA())}function k(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Email already exist"),e.qZA())}function I(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Mobile can't be blank"),e.qZA())}function S(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Mobile is invalid"),e.qZA())}function P(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Date of birth can't be blank"),e.qZA())}function L(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Minimum Age must be 18"),e.qZA())}function J(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Password can't be blank"),e.qZA())}function M(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Password can't be blank"),e.qZA())}function B(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Password and Confirm password does not match"),e.qZA())}function E(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Please select gender"),e.qZA())}function O(r,t){if(1&r&&(e.TgZ(0,"div",36),e._UZ(1,"input",37),e.TgZ(2,"label",38),e._uU(3),e.qZA(),e.YNc(4,E,2,0,"span",10),e.qZA()),2&r){const i=t.$implicit,n=e.oxw();e.xp6(1),e.Q6J("id",i)("value",i),e.xp6(1),e.Q6J("for",i),e.xp6(1),e.hij(" ",i," "),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("gender").invalid&&(n.signUpForm.get("gender").dirty||n.signUpForm.get("gender").touched||n.signUpForm.submitted)&&(null==n.signUpForm.get("gender").errors?null:n.signUpForm.get("gender").errors.required))}}function Q(r,t){if(1&r&&(e.TgZ(0,"option",39),e._uU(1),e.qZA()),2&r){const i=t.$implicit;e.Q6J("value",i.countryID),e.xp6(1),e.Oqu(i.countryName)}}function D(r,t){1&r&&(e.TgZ(0,"span",35),e._uU(1,"Please select Country"),e.qZA())}function Y(r,t){if(1&r&&(e.TgZ(0,"option",39),e._uU(1),e.qZA()),2&r){const i=t.$implicit;e.Q6J("value",i),e.xp6(1),e.Oqu(i)}}const m=function(r,t){return{"is-invalid":r,"is-valid":t}};function V(r,t){if(1&r){const i=e.EpF();e.TgZ(0,"div",40),e.TgZ(1,"div",41),e._UZ(2,"input",42),e.qZA(),e.TgZ(3,"div",43),e.TgZ(4,"select",44),e.TgZ(5,"option",26),e._uU(6,"Please Select"),e.qZA(),e.YNc(7,Y,2,2,"option",27),e.qZA(),e.qZA(),e.TgZ(8,"div",45),e.TgZ(9,"button",46),e.NdJ("click",function(){const a=e.CHM(i).index;return e.oxw().onRemoveClick(a)}),e._uU(10,"Remove"),e.qZA(),e.qZA(),e.qZA()}if(2&r){const i=t.$implicit,n=t.index,s=e.oxw();e.Q6J("formGroupName",n),e.xp6(2),e.Q6J("ngClass",e.WLB(4,m,i.get("skillsName").invalid&&(i.get("skillsName").dirty||i.get("skillsName").touched||i.submitted),i.get("skillsName").valid&&(i.get("skillsName").dirty||i.get("skillsName").touched||i.submitted))),e.xp6(2),e.Q6J("ngClass",e.WLB(7,m,i.get("skillsLevel").invalid&&(i.get("skillsLevel").dirty||i.get("skillsLevel").touched||i.submitted),i.get("skillsLevel").valid&&(i.get("skillsLevel").dirty||i.get("skillsLevel").touched||i.submitted))),e.xp6(3),e.Q6J("ngForOf",s.arrayLevels)}}const R=[{path:"",redirectTo:"/",pathMatch:"full"},{path:"",component:(()=>{class r{constructor(){}ngOnInit(){}}return r.\u0275fac=function(i){return new(i||r)},r.\u0275cmp=e.Xpm({type:r,selectors:[["app-home"]],decls:2,vars:0,template:function(i,n){1&i&&(e.TgZ(0,"p"),e._uU(1,"home works!"),e.qZA())},styles:[""]}),r})()},{path:"login",component:Z,data:{linkIndex:2}},{path:"signup",component:(()=>{class r{constructor(i,n,s,a){this.countryService=i,this.customValidatorService=n,this.loginService=s,this.router=a,this.genders=["Male","Female"],this.arrayLevels=["Beginner","Intermediate","Professional","Expert"],this.countries=[],this.registerError=null,this.canLeave=!0}ngOnInit(){this.initialFormState(),this.getCountries()}initialFormState(){this.signUpForm=new o.cw({personName:new o.cw({firstName:new o.NI(null,[o.kI.required,o.kI.minLength(3)]),lastName:new o.NI(null,[o.kI.required,o.kI.minLength(3)])}),email:new o.NI(null,[o.kI.required,o.kI.email],[this.customValidatorService.DuplicateEmailValidator()]),mobile:new o.NI(null,[o.kI.required,o.kI.pattern(/^[789]\d{9}$/)]),dateOfBirth:new o.NI(null,[o.kI.required,this.customValidatorService.minimumAgeValidator(18)]),Password:new o.NI(null,o.kI.required),confirmPassword:new o.NI(null,o.kI.required),gender:new o.NI(null,o.kI.required),countryID:new o.NI(null,o.kI.required),receiveNewsLetters:new o.NI(null),skills:new o.Oe([])},{validators:[this.customValidatorService.confirmPasswordValidator("confirmPassword","Password")]}),this.signUpForm.valueChanges.subscribe(i=>{this.canLeave=!1})}getCountries(){this.countryService.getCountries().subscribe({next:i=>{this.countries=i},error:()=>{}})}onSubmitClick(){this.signUpForm.submitted=!0,console.log(this.signUpForm.value),this.signUpForm.valid&&this.loginService.Register(this.signUpForm.value).subscribe({next:n=>{this.canLeave=!0,this.router.navigate(["/employee","tasks"])},error:n=>{console.log(n),this.registerError="Unable to submit"}})}onAddSkill(){let i=new o.cw({skillsName:new o.NI(null,[o.kI.required,o.kI.minLength(3)]),skillsLevel:new o.NI(null,o.kI.required)});this.signUpForm.get("skills").push(i)}onRemoveClick(i){this.signUpForm.get("skills").removeAt(i)}}return r.\u0275fac=function(i){return new(i||r)(e.Y36(N.K),e.Y36(_),e.Y36(d.r),e.Y36(p.F0))},r.\u0275cmp=e.Xpm({type:r,selectors:[["app-signup"]],decls:89,vars:52,consts:[[1,"row"],[1,"col-md-8","col-xl-6","mx-auto"],[3,"formGroup","ngSubmit"],[1,"card","mt-1"],[1,"card-header"],[1,"card-body"],["formGroupName","personName",1,"form-group","form-row"],["for","firstName",1,"col-md-4","col-form-label"],[1,"col-md-8"],["type","text","name","firstName","id","firstName","placeholder","First Name","formControlName","firstName",1,"form-control",3,"ngClass"],["class","text-danger",4,"ngIf"],["for","lastName",1,"col-md-4","col-form-label"],["type","text","name","lastName","id","lastName","placeholder","Last Name","formControlName","lastName",1,"form-control",3,"ngClass"],[1,"form-group","form-row"],["for","email",1,"col-md-4","col-form-label"],["type","email","name","email","id","email","placeholder","Email","formControlName","email",1,"form-control",3,"ngClass"],["for","mobile",1,"col-md-4","col-form-label"],["type","tel","name","mobile","id","mobile","placeholder","Mobile","formControlName","mobile",1,"form-control",3,"ngClass"],["for","dateOfBirth",1,"col-md-4","col-form-label"],["type","date","name","dateOfBirth","id","dateOfBirth","placeholder","Date of Birth","formControlName","dateOfBirth",1,"form-control",3,"ngClass"],["type","password","name","Password","id","password","placeholder","Password","formControlName","Password",1,"form-control",3,"ngClass"],["type","password","name","confirmPassword","id","confirmPassword","placeholder","Confirm Password","formControlName","confirmPassword",1,"form-control",3,"ngClass"],[1,"col-md-4","col-form-label"],["class","form-check-label form-check-inline",4,"ngFor","ngForOf"],["for","countryID",1,"col-md-4","col-form-label"],["name","countryID","id","countryID","formControlName","countryID",1,"form-control",3,"ngClass"],["value","null"],[3,"value",4,"ngFor","ngForOf"],["type","checkbox","name","receiveNewsLetters","id","receiveNewsLetters","value","true","formControlName","receiveNewsLetters",1,"form-check-input"],["for","receiveNewsLetters",1,"form-check-label"],["formArrayName","skills",1,"col-md-8"],["class","row",3,"formGroupName",4,"ngFor","ngForOf"],["type","button",1,"btn","btn-primary",3,"click"],[1,"card-footer"],[1,"btn","btn-success","float-right"],[1,"text-danger"],[1,"form-check-label","form-check-inline"],["type","radio","name","gender","formControlName","gender",1,"form-check-input",3,"id","value"],[1,"form-check-label",3,"for"],[3,"value"],[1,"row",3,"formGroupName"],[1,"col-5"],["type","text","name","skillsName","id","skillsName","placeholder","Skill Name","formControlName","skillsName",1,"form-control",3,"ngClass"],[1,"col-4"],["name","skillsLevel","id","skillsLevel","formControlName","skillsLevel",1,"form-control",3,"ngClass"],[1,"col-3"],["type","button",1,"btn","btn-danger",3,"click"]],template:function(i,n){1&i&&(e.TgZ(0,"div",0),e.TgZ(1,"div",1),e.TgZ(2,"form",2),e.NdJ("ngSubmit",function(){return n.onSubmitClick()}),e.TgZ(3,"div",3),e.TgZ(4,"div",4),e.TgZ(5,"h4"),e._uU(6,"Sign Up"),e.qZA(),e.qZA(),e.TgZ(7,"div",5),e.TgZ(8,"div",6),e.TgZ(9,"label",7),e._uU(10,"First Name:"),e.qZA(),e.TgZ(11,"div",8),e._UZ(12,"input",9),e.YNc(13,C,2,0,"span",10),e.YNc(14,T,2,0,"span",10),e.qZA(),e.qZA(),e.TgZ(15,"div",6),e.TgZ(16,"label",11),e._uU(17,"Last Name:"),e.qZA(),e.TgZ(18,"div",8),e._UZ(19,"input",12),e.YNc(20,y,2,0,"span",10),e.YNc(21,A,2,0,"span",10),e.qZA(),e.qZA(),e.TgZ(22,"div",13),e.TgZ(23,"label",14),e._uU(24,"Email:"),e.qZA(),e.TgZ(25,"div",8),e._UZ(26,"input",15),e.YNc(27,q,2,0,"span",10),e.YNc(28,w,2,0,"span",10),e.YNc(29,k,2,0,"span",10),e.qZA(),e.qZA(),e.TgZ(30,"div",13),e.TgZ(31,"label",16),e._uU(32,"Mobile:"),e.qZA(),e.TgZ(33,"div",8),e._UZ(34,"input",17),e.YNc(35,I,2,0,"span",10),e.YNc(36,S,2,0,"span",10),e.qZA(),e.qZA(),e.TgZ(37,"div",13),e.TgZ(38,"label",18),e._uU(39,"Date of Birth:"),e.qZA(),e.TgZ(40,"div",8),e._UZ(41,"input",19),e.YNc(42,P,2,0,"span",10),e.YNc(43,L,2,0,"span",10),e.qZA(),e.qZA(),e.TgZ(44,"div",13),e.TgZ(45,"label",18),e._uU(46,"Password:"),e.qZA(),e.TgZ(47,"div",8),e._UZ(48,"input",20),e.YNc(49,J,2,0,"span",10),e.qZA(),e.qZA(),e.TgZ(50,"div",13),e.TgZ(51,"label",18),e._uU(52,"Confirm Password:"),e.qZA(),e.TgZ(53,"div",8),e._UZ(54,"input",21),e.YNc(55,M,2,0,"span",10),e.YNc(56,B,2,0,"span",10),e.qZA(),e.qZA(),e.TgZ(57,"div",13),e.TgZ(58,"label",22),e._uU(59,"Gender"),e.qZA(),e.TgZ(60,"div",8),e.YNc(61,O,5,5,"div",23),e.qZA(),e.qZA(),e.TgZ(62,"div",13),e.TgZ(63,"label",24),e._uU(64,"Country"),e.qZA(),e.TgZ(65,"div",8),e.TgZ(66,"select",25),e.TgZ(67,"option",26),e._uU(68,"Please Select"),e.qZA(),e.YNc(69,Q,2,2,"option",27),e.qZA(),e.YNc(70,D,2,0,"span",10),e.qZA(),e.qZA(),e.TgZ(71,"div",13),e._UZ(72,"label",22),e.TgZ(73,"div",8),e._UZ(74,"input",28),e.TgZ(75,"label",29),e._uU(76,"Receive News Letters"),e.qZA(),e.qZA(),e.qZA(),e.TgZ(77,"div",13),e.TgZ(78,"label",22),e._uU(79,"Skills"),e.qZA(),e.TgZ(80,"div",30),e.YNc(81,V,11,10,"div",31),e.TgZ(82,"button",32),e.NdJ("click",function(){return n.onAddSkill()}),e._uU(83,"Add Skill"),e.qZA(),e.qZA(),e.qZA(),e.qZA(),e.TgZ(84,"div",33),e.TgZ(85,"button",34),e._uU(86,"Create Account"),e.qZA(),e.TgZ(87,"div",35),e._uU(88),e.qZA(),e.qZA(),e.qZA(),e.qZA(),e.qZA(),e.qZA()),2&i&&(e.xp6(2),e.Q6J("formGroup",n.signUpForm),e.xp6(10),e.Q6J("ngClass",e.WLB(28,m,n.signUpForm.get("personName.firstName").invalid&&(n.signUpForm.get("personName.firstName").dirty||n.signUpForm.get("personName.firstName").touched||n.signUpForm.submitted),n.signUpForm.get("personName.firstName").valid&&(n.signUpForm.get("personName.firstName").dirty||n.signUpForm.get("personName.firstName").touched||n.signUpForm.submitted))),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("personName.firstName").invalid&&(n.signUpForm.get("personName.firstName").dirty||n.signUpForm.get("personName.firstName").touched||n.signUpForm.submitted)&&n.signUpForm.get("personName.firstName").errors.required),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("personName.firstName").invalid&&(n.signUpForm.get("personName.firstName").dirty||n.signUpForm.get("personName.firstName").touched||n.signUpForm.submitted)&&(null==n.signUpForm.get("personName.firstName").errors?null:n.signUpForm.get("personName.firstName").errors.minlength)),e.xp6(5),e.Q6J("ngClass",e.WLB(31,m,n.signUpForm.get("personName.lastName").invalid&&(n.signUpForm.get("personName.lastName").dirty||n.signUpForm.get("personName.lastName").touched||n.signUpForm.submitted),n.signUpForm.get("personName.lastName").valid&&(n.signUpForm.get("personName.lastName").dirty||n.signUpForm.get("personName.lastName").touched||n.signUpForm.submitted))),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("personName.lastName").invalid&&(n.signUpForm.get("personName.lastName").dirty||n.signUpForm.get("personName.lastName").touched||n.signUpForm.submitted)&&n.signUpForm.get("personName.lastName").errors.required),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("personName.lastName").invalid&&(n.signUpForm.get("personName.lastName").dirty||n.signUpForm.get("personName.lastName").touched||n.signUpForm.submitted)&&(null==n.signUpForm.get("personName.lastName").errors?null:n.signUpForm.get("personName.lastName").errors.minlength)),e.xp6(5),e.Q6J("ngClass",e.WLB(34,m,n.signUpForm.get("email").invalid&&(n.signUpForm.get("email").dirty||n.signUpForm.get("email").touched||n.signUpForm.submitted),n.signUpForm.get("email").valid&&(n.signUpForm.get("email").dirty||n.signUpForm.get("email").touched||n.signUpForm.submitted))),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("email").invalid&&(n.signUpForm.get("email").dirty||n.signUpForm.get("email").touched||n.signUpForm.submitted)&&n.signUpForm.get("email").errors.required),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("email").invalid&&(n.signUpForm.get("email").dirty||n.signUpForm.get("email").touched||n.signUpForm.submitted)&&(null==n.signUpForm.get("email").errors?null:n.signUpForm.get("email").errors.email)),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("email").invalid&&(n.signUpForm.get("email").dirty||n.signUpForm.get("email").touched||n.signUpForm.submitted)&&(null==n.signUpForm.get("email").errors?null:n.signUpForm.get("email").errors.uniqueEmail)),e.xp6(5),e.Q6J("ngClass",e.WLB(37,m,n.signUpForm.get("mobile").invalid&&(n.signUpForm.get("mobile").dirty||n.signUpForm.get("mobile").touched||n.signUpForm.submitted),n.signUpForm.get("mobile").valid&&(n.signUpForm.get("mobile").dirty||n.signUpForm.get("mobile").touched||n.signUpForm.submitted))),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("mobile").invalid&&(n.signUpForm.get("mobile").dirty||n.signUpForm.get("mobile").touched||n.signUpForm.submitted)&&n.signUpForm.get("mobile").errors.required),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("mobile").invalid&&(n.signUpForm.get("mobile").dirty||n.signUpForm.get("mobile").touched||n.signUpForm.submitted)&&(null==n.signUpForm.get("mobile").errors?null:n.signUpForm.get("mobile").errors.pattern)),e.xp6(5),e.Q6J("ngClass",e.WLB(40,m,n.signUpForm.get("dateOfBirth").invalid&&(n.signUpForm.get("dateOfBirth").dirty||n.signUpForm.get("dateOfBirth").touched||n.signUpForm.submitted),n.signUpForm.get("dateOfBirth").valid&&(n.signUpForm.get("dateOfBirth").dirty||n.signUpForm.get("dateOfBirth").touched||n.signUpForm.submitted))),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("dateOfBirth").invalid&&(n.signUpForm.get("dateOfBirth").dirty||n.signUpForm.get("dateOfBirth").touched||n.signUpForm.submitted)&&n.signUpForm.get("dateOfBirth").errors.required),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("dateOfBirth").invalid&&(n.signUpForm.get("dateOfBirth").dirty||n.signUpForm.get("dateOfBirth").touched||n.signUpForm.submitted)&&(null==n.signUpForm.get("dateOfBirth").errors?null:n.signUpForm.get("dateOfBirth").errors.minAge)),e.xp6(5),e.Q6J("ngClass",e.WLB(43,m,n.signUpForm.get("Password").invalid&&(n.signUpForm.get("Password").dirty||n.signUpForm.get("Password").touched||n.signUpForm.submitted),n.signUpForm.get("Password").valid&&(n.signUpForm.get("Password").dirty||n.signUpForm.get("Password").touched||n.signUpForm.submitted))),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("Password").invalid&&(n.signUpForm.get("Password").dirty||n.signUpForm.get("Password").touched||n.signUpForm.submitted)&&(null==n.signUpForm.get("Password").errors?null:n.signUpForm.get("Password").errors.required)),e.xp6(5),e.Q6J("ngClass",e.WLB(46,m,n.signUpForm.get("confirmPassword").invalid&&(n.signUpForm.get("confirmPassword").dirty||n.signUpForm.get("confirmPassword").touched||n.signUpForm.submitted),n.signUpForm.get("confirmPassword").valid&&(n.signUpForm.get("confirmPassword").dirty||n.signUpForm.get("confirmPassword").touched||n.signUpForm.submitted))),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("confirmPassword").invalid&&(n.signUpForm.get("confirmPassword").dirty||n.signUpForm.get("confirmPassword").touched||n.signUpForm.submitted)&&n.signUpForm.get("confirmPassword").errors.required),e.xp6(1),e.Q6J("ngIf",n.signUpForm.invalid&&(n.signUpForm.dirty||n.signUpForm.touched||n.signUpForm.submitted)&&(null==n.signUpForm.errors?null:n.signUpForm.errors.compareValidator)),e.xp6(5),e.Q6J("ngForOf",n.genders),e.xp6(5),e.Q6J("ngClass",e.WLB(49,m,n.signUpForm.get("countryID").invalid&&(n.signUpForm.get("countryID").dirty||n.signUpForm.get("countryID").touched||n.signUpForm.submitted),n.signUpForm.get("countryID").valid&&(n.signUpForm.get("countryID").dirty||n.signUpForm.get("countryID").touched||n.signUpForm.submitted))),e.xp6(3),e.Q6J("ngForOf",n.countries),e.xp6(1),e.Q6J("ngIf",n.signUpForm.get("countryID").invalid&&(n.signUpForm.get("countryID").dirty||n.signUpForm.get("countryID").touched||n.signUpForm.submitted)&&(null==n.signUpForm.get("countryID").errors?null:n.signUpForm.get("countryID").errors.required)),e.xp6(11),e.Q6J("ngForOf",n.signUpForm.get("skills").controls),e.xp6(7),e.Oqu(n.registerError))},directives:[o._Y,o.JL,o.sg,o.x0,o.Fj,o.JJ,o.u,g.mk,g.O5,g.sg,o.EJ,o.YN,o.Kr,o.Wl,o.CE,o._],styles:[""]}),r})(),canDeactivate:[(()=>{class r{constructor(){}canDeactivate(i,n,s,a){return!0===i.canLeave||confirm("Do you want to discard changes")}}return r.\u0275fac=function(i){return new(i||r)},r.\u0275prov=e.Yz7({token:r,factory:r.\u0275fac,providedIn:"root"}),r})()],data:{linkIndex:3}},{path:"about",component:(()=>{class r{constructor(){}ngOnInit(){}}return r.\u0275fac=function(i){return new(i||r)},r.\u0275cmp=e.Xpm({type:r,selectors:[["app-about"]],decls:2,vars:0,template:function(i,n){1&i&&(e.TgZ(0,"p"),e._uU(1,"about works!"),e.qZA())},styles:[""]}),r})(),data:{linkIndex:1}},{path:"admin",loadChildren:()=>l.e(734).then(l.bind(l,8734)).then(r=>r.AdminModule)},{path:"employee",loadChildren:()=>Promise.resolve().then(l.bind(l,227)).then(r=>r.EmployeeModule)}];let G=(()=>{class r{}return r.\u0275fac=function(i){return new(i||r)},r.\u0275mod=e.oAB({type:r}),r.\u0275inj=e.cJS({imports:[[p.Bz.forChild(R)],p.Bz]}),r})(),W=(()=>{class r{}return r.\u0275fac=function(i){return new(i||r)},r.\u0275mod=e.oAB({type:r}),r.\u0275inj=e.cJS({imports:[[g.ez,G]]}),r})()},5517:(U,u,l)=>{l.d(u,{K:()=>c});var g=l(3556),p=l(4522);let c=(()=>{class e{constructor(o){this.httpClient=o}getCountries(){return this.httpClient.get("/api/countries",{responseType:"json"})}getCountryByCountID(o){return this.httpClient.get("/api/countries/searchBycountryid/"+o,{responseType:"json"})}insertCountry(o){return this.httpClient.post("/api/countries",o,{responseType:"json"})}updateCountry(o){return this.httpClient.put("/api/countries",o,{responseType:"json"})}deleteCountry(o){return this.httpClient.delete("/api/countries?existingCountry="+o)}}return e.\u0275fac=function(o){return new(o||e)(g.LFG(p.eN))},e.\u0275prov=g.Yz7({token:e,factory:e.\u0275fac,providedIn:"root"}),e})()}}]);