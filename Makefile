install:
	dotnet restore src/App
	dotnet restore tests/App.Tests

setup: install
	dotnet publish src/App -c Release -o dist

build:
	dotnet build

clean:
	dotnet clean
	rm -rf dist

run:
	dotnet run --project src/App

run-dist:
	./dist/App

update-deps:
	dotnet-outdated

build-run: build run

lint:
	dotnet csharpier check .
	
lint-fix:
	dotnet csharpier format .

test:
	dotnet test --project tests/App.Tests

test-coverage:
	dotnet test --project tests/App.Tests --coverlet
