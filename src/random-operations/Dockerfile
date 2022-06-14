FROM python:3.8-alpine
WORKDIR /usr/src/app
COPY requirements.req ./
RUN pip install --no-cache-dir -r requirements.req
COPY . .
CMD [ "python", "./random-ops.py" ]