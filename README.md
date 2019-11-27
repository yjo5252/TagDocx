# AutomaticDocumentCategorizeService

##1. 프로젝트 소개
  이 프로젝트를 통해 해결/완화하고자하는 문제에 대해 기술
  과제나 프로젝트 진행 시에 생성하거나 다운로드한 파일들을 미리 잘 저장해두지 않으면 나중에 따로 분류하기 위해서 시간을 들여야하고, 정확한 제목과 위치를 알지 못하면 필요한 파일들을 찾을 때 어려움이 생긴다.

####1. 파일 검색 시에 생기는 불편함
  - 제목을 정확히 알지 못함
  - 저장된 위치를 정확히 알지 못함
  - 검색 소요 시간이 너무 오래걸림
####2. 파일 저장,다운로드 시 생기는 불편함 
  - 자동 저장된 폴더 위치 알지 못함
  - 크롬의 경우 저장시에 파일 이름을 사용자가 지정하지 못함
  - 크롬/카카오톡/의 경우 파일이 저장되는 폴더위치 정하지 못하여 사용자가 경로를 찾기 힘든 경우가 많음
  - 하위 폴더 수가 많아서 정리와 탐색 시간이 오래 걸림
  - 매번 폴더를 지정하는것 불편함
##2. 프로젝트 구성
  사용자가 직접 태그를 붙이거나 파일의 이름을 정하지 않더라도 파일의 내용을 분석하여 태그를 할당한다. 파일에 태그를 설정할 수 있게 된다면, 파일의 태그를 이용하여 태그별로 파일을 분류하게 되어 확장자가 아닌 내용의 연관성을 따질 수 있게 된다. 또한, 파일을 찾을 때는 파일의 내용은 대략적으로 알지만 제목을 모를때, 혹은 제목을 내용과는 상관없는 것으로 지었을 때 태그를 이용하여 효율적으로 파일을 찾을 수 있다.,이메일 서비스와 결합하여 이메일을 쓸 때 이메일의 내용을 분석하여 파일을 첨부해야 할 경우에 분석한 내용을 토대로 첨부할 파일을 추천한다.구현할 기능은 다음과 같다.
    1. 자동으로 파일 태깅 : 태그가 생성되지 않은 파일들을 분석하여 태그를 달아주는 기능
    2. 검색 : 파일을 검색하고 싶지만 파일의 제목이 기억이 나지 않거나 파일의 경로, 내용을 모르지만 키워드는 알고 있을 때 파일을 쉽게 찾을 수 있게 하기 위하여 지원하는 검색 기능
    2-1.추가 기능
      1) 검색결과로 나온 파일들의 목록에서 파일을 더블클릭하면 파일이 열린다.
      2) 검색결과로 나온 파일들의 목록에서 파일에 마우스를 가져다 대고 오른쪽 버튼을 클릭하면 파일의 경로를 확인할 수 있다.
    3. 분류 : 파일들의 태그를 이용하여 유사한 내용, 주제를 가진 파일끼리 폴더에 분류하여 저장경로를 이동하는 기능.
##3. 인터페이스
  <iframe width="640" height="360" src="youtube url 넣기"></iframe>
##4. 








