<h1>S.O.L.I.D.</h1>
<ul>
<li>S - Seperation Of Concern</li>
<li>O - Open for extension closed for implementation</li>
<li>I - Interface Segregation</li>
<li>D - Dependency injection Inversion of Control</li>
</ul>
Any Application architecture should adhere SOLID principle to ensure certain basic things
<ul>
  <li>max support for design patterns</li>
  <li>balance between 7 concerns of Architecture e.g. Performance, Scalability, Maintainability, Availability, Operability, Interoperability </li>
  <li>To maintain KISS [Keep it simple]</li>
  <li>To ensure DRY [Don't Repeat Yourself]
</ul>

Problem Statement: Read a excel file or Sql or Mongo source and populate Product Model
Steps:
<ul>
<li>S - Sourceparser class - ISourceType</li> 
<li>File read</li> 
<li>I - Product structure adhering Solid</li>
<li>ISourceType - Parser()</li>
<li>O,L - Product extensible for change notify.Upon Notification conversion from flat structure to concerete structure</li>
<li>D - Unittest, ISourceType</li>
<li>ISourceType - Parser()</li>
<li>Sql:ISourceType</li>
<li>Mongo: ISourceType</li>
<li>Excel: ISourceType</li>
<li>Csv: ISourceType</li>
<li></li>
<li>Excel/ other Parser class DI Constructor ISourceType - Parser() - implement all type - DI unserstand source config based</li>
<li>IInComingProducts - will call Parser through dependency injection</li>
<li>InComingProducts DI ISourceType : IInComingProducts - src.Parse();- flat properties DBFirst</li>
<li>Product class - Model - SOLID - abstract Base - NotifyChange()</li> 
</ul>


