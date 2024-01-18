setup:
	dotnet build --property:OutputPath=Coupon_Export
	move Coupon_Export ..
	
run:
	..\Coupon_Export\CouponCodeGenerator.exe

pack:
	dotnet pack --property:OutputPath=Coupon_Pack
	move Coupon_Pack ..