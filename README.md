# ProEventos

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 15.0.1.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.


## Intallations

### instalar angular cli
npm install -g @angular/cli

### instalar fontawesome
npm install --save @fortawesome/fontawesome-free

### instalar bootstrap
npm install bootstrap@5

### instalar ngx-bootstrap
ng add ngx-bootstrap



## ProEventos\ProEventos-API\src

### criar solução
dotnet new sln -n ProEventos

### criar projeto
dotnet new classLib -n ProEventos-Persistence
dotnet new classLib -n ProEventos-Domain
dotnet new classLib -n ProEventos-Application

### add projeto a solução
dotnet sln ProEventos.sln add .\ProEventos-API\
dotnet sln ProEventos.sln add .\ProEventos-Application\
dotnet sln ProEventos.sln add .\ProEventos-Domain\
dotnet sln ProEventos.sln add .\ProEventos-Persistence\

### referencia
dotnet add .\ProEventos-API\ProEventos-API.csproj reference .\ProEventos-Application\