
build:
	docker build -t bernardolm/meuponto-api-csharp .

run: build
	docker run -p 4321:4321 -t bernardolm/meuponto-api-csharp

